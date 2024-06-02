using System.Security.Claims;
using System.Text.Json.Nodes;

using BCrypt.Net;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Data;
using Naja.Models.External;

public class AccountController : Controller
{
    private readonly XiContext _context;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<AccountController> _logger;

    public AccountController(XiContext context, IHttpClientFactory httpClientFactory, ILogger<AccountController> logger)
    {
        _context = context;
        _httpClientFactory = httpClientFactory;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        var accountId = User.FindFirst("AccountId")?.Value;
        if (accountId != null)
        {
            return RedirectToAction("Index", "AccountCharacters");
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        var account = await _context.Accounts
            .FirstOrDefaultAsync(a => a.Login == model.Login);

        if (account == null || !BCrypt.Net.BCrypt.Verify(model.Password, account.Password))
        {
            ViewData["ErrorMessage"] = "Invalid login attempt.";
            return View(model);
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, account.Login),
            new Claim("AccountId", account.Id.ToString())
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties
        {
            IsPersistent = model.RememberMe,
            AllowRefresh = true,
            ExpiresUtc = model.RememberMe
                ? DateTimeOffset.UtcNow.AddDays(14) // Persistent cookie for 14 days
                : DateTimeOffset.UtcNow.AddMinutes(30) // Session cookie for 30 minutes
        };

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            authProperties);

        return RedirectToAction("Index", "AccountCharacters");
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login", "Account");
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        // Validate reCAPTCHA response
        var recaptchaResult = await ValidateRecaptchaAsync(Request.Form["g-recaptcha-response"]);
        if (!recaptchaResult)
        {
            ViewData["ErrorMessage"] = "reCAPTCHA verification failed. Please try again.";
            return View(model);
        }

        // Check if username already exists
        if (await _context.Accounts.AnyAsync(a => a.Login == model.Username))
        {
            ViewData["ErrorMessage"] = "Username already exists.";
            return View(model);
        }

        var maxId = await _context.Accounts
            .Select(acct => (uint?)acct.Id)
            .DefaultIfEmpty()
            .MaxAsync();
        var newId = maxId.HasValue && maxId.Value > 999 ? maxId.Value + 1 : 1000;
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);

        var account = new Account
        {
            Id = newId,
            Login = model.Username,
            Password = passwordHash,
            RegistrationEmail = model.Email,
            CurrentEmail = model.Email,
            Timecreate = DateTime.Now,
            Timelastmodify = DateTime.Now,
            Status = Account.StatusCodes.Normal,
            Priv = Account.PrivilegeCodes.User,
        };

        _context.Accounts.Add(account);
        await _context.SaveChangesAsync();

        return RedirectToAction("Login");
    }

    private async Task<bool> ValidateRecaptchaAsync(string? recaptchaResponse)
    {
        if (string.IsNullOrEmpty(recaptchaResponse))
        {
            return false;
        }
        try
        {
            var client = _httpClientFactory.CreateClient();
            var secretKey = DotNetEnv.Env.GetString("RECAPTCHA_SECRET");
            var response = await client.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={recaptchaResponse}");

            var jsonNode = JsonNode.Parse(response);
            return jsonNode?["success"]?.GetValue<bool>() ?? false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while validating reCAPTCHA response.");
            return false;
        }
    }

}
