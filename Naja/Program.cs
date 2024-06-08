using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

using Naja.Models.External;
using Naja.Services;

using Pomelo.EntityFrameworkCore.MySql;

DotNetEnv.Env.Load("../.env");

var builder = WebApplication.CreateBuilder(args);
var environment = builder.Environment.EnvironmentName;

// Add services to the container.
var connectionString = $"Server={DotNetEnv.Env.GetString("SERVER")};Database={DotNetEnv.Env.GetString("DATABASE")};User={DotNetEnv.Env.GetString("USER")};Password={DotNetEnv.Env.GetString("PASSWORD")};";

builder.Services.AddDbContext<XidbContext>(options => options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    ));

builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
        if (environment == Environments.Production)
        {
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        }
        else
        {
            options.Cookie.SecurePolicy = CookieSecurePolicy.None;
        }
    });

builder.Services.AddSingleton<XmlService>();
builder.Services.AddSingleton<IClientResourcesService, ClientResourcesService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IChatService, ChatService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "ah",
    pattern: "{controller=AuctionHouse}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "items",
    pattern: "{controller=Items}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "account",
    pattern: "{controller=Account}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "accountCharacters",
    pattern: "{controller=AccountCharacters}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "yells",
    pattern: "{controller=Yells}/{action=Index}/{id?}");

app.Run();
