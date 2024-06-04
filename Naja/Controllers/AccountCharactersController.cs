using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Naja.Data;
using Naja.Models;
using Naja.Models.External;

namespace Naja
{
    [Route("Account/Characters")]
    [Authorize]
    public class AccountCharactersController : Controller
    {
        private readonly XiContext _context;
        private readonly AccountService _accountService;
        private readonly CharService _charService;

        public AccountCharactersController(XiContext context, AccountService accountService, CharService charService)
        {
            _context = context;
            _accountService = accountService;
            _charService = charService;
        }

        // GET: Account/Characters
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            var chars = await _context.Chars.Where(c => c.Accid == accountId).ToListAsync();

            var charViewModels = new List<CharViewModel>();
            foreach (var character in chars)
            {
                var zoneName = _charService.GetCurrentZoneName(character.PosZone);
                var nationName = _charService.GetNationName(character.Nation);
                var nationImageUrl = _charService.GetNationImageUrl(character.Nation);

                var viewModel = new CharViewModel
                {
                    Char = character,
                    ZoneName = zoneName,
                    NationName = nationName,
                    NationImageUrl = nationImageUrl
                };

                charViewModels.Add(viewModel);
            }

            return View(charViewModels);
        }

        // POST: Account/Characters/SelectCharacter
        [HttpPost("SelectCharacter")]
        public async Task<IActionResult> SelectCharacter(int id)
        {
            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            var character = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == accountId);
            if (character == null)
            {
                return NotFound();
            }

            var claimsPrincipal = HttpContext.User;

            if (claimsPrincipal.Identity is ClaimsIdentity currentClaimsIdentity)
            {
                var existingCharacterIdClaim = currentClaimsIdentity.FindFirst("CharacterId");
                var existingCharacterNameClaim = currentClaimsIdentity.FindFirst("CharacterName");

                if (existingCharacterIdClaim != null && existingCharacterNameClaim != null)
                {
                    currentClaimsIdentity.RemoveClaim(existingCharacterIdClaim);
                    currentClaimsIdentity.RemoveClaim(existingCharacterNameClaim);
                }

                currentClaimsIdentity.AddClaim(new Claim("CharacterId", character.Charid.ToString()));
                currentClaimsIdentity.AddClaim(new Claim("CharacterName", character.Charname));

                var authProperties = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(currentClaimsIdentity),
                    authProperties.Properties);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return RedirectToAction("Index", "Home");
        }

        // GET: Account/Character/5/Details
        [HttpGet("{id}/Details")]
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            var character = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == accountId);
            if (character == null)
            {
                return NotFound();
            }

            var zoneName = _charService.GetCurrentZoneName(character.PosZone);
            var nationName = _charService.GetNationName(character.Nation);
            var nationImageUrl = _charService.GetNationImageUrl(character.Nation);

            var viewModel = new CharViewModel
            {
                Char = character,
                ZoneName = zoneName,
                NationName = nationName,
                NationImageUrl = nationImageUrl
            };

            return View(viewModel);
        }

        // GET: Account/Characters/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }
            return View();
        }

        // POST: Account/Characters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Charid,Accid,OriginalAccid,Charname,Nation,PosZone,PosPrevzone,PosRot,PosX,PosY,PosZ,Moghouse,Boundary,HomeZone,HomeRot,HomeX,HomeY,HomeZ,Missions,Assault,Campaign,Eminence,Quests,Keyitems,SetBlueSpells,Abilities,Weaponskills,Titles,Zones,Playtime,UnlockedWeapons,Gmlevel,Languages,Mentor,JobMaster,CampaignAllegiance,Isstylelocked,Settings,Chatfilters1,Chatfilters2,Moghancement,Timecreated,Lastupdate")] Models.External.Char newChar)
        {
            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid)
            {
                newChar.Accid = (uint)accountId;
                _context.Add(newChar);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", newChar.Charid);
            }
            return View(newChar);
        }

        // GET: Account/Characters/5/Edit
        [HttpGet("{id}/Edit")]
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            var charToEdit = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == accountId);
            if (charToEdit == null)
            {
                return NotFound();
            }
            return View(charToEdit);
        }

        // POST: Account/Characters/5/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("{id}/Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Charid,Accid,OriginalAccid,Charname,Nation,PosZone,PosPrevzone,PosRot,PosX,PosY,PosZ,Moghouse,Boundary,HomeZone,HomeRot,HomeX,HomeY,HomeZ,Missions,Assault,Campaign,Eminence,Quests,Keyitems,SetBlueSpells,Abilities,Weaponskills,Titles,Zones,Playtime,UnlockedWeapons,Gmlevel,Languages,Mentor,JobMaster,CampaignAllegiance,Isstylelocked,Settings,Chatfilters1,Chatfilters2,Moghancement,Timecreated,Lastupdate")] Models.External.Char charToEdit)
        {
            if (id != charToEdit.Charid)
            {
                return NotFound();
            }

            var accountId = _accountService.GetAccountId();
            if (accountId == null || charToEdit.Accid != accountId)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(charToEdit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharExists(charToEdit.Charid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", charToEdit.Charid);
            }
            return View(charToEdit);
        }

        // GET: Account/Characters/5/Delete
        [HttpGet("{id}/Delete")]
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            var charToDelete = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == accountId);
            if (charToDelete == null)
            {
                return NotFound();
            }

            return View(charToDelete);
        }

        // POST: Chars/Delete/5
        [HttpPost("{id}/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var accountId = _accountService.GetAccountId();
            if (accountId == null)
            {
                return Unauthorized();
            }

            var charToDelete = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == accountId);

            if (charToDelete != null)
            {
                _context.Chars.Remove(charToDelete);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CharExists(uint id)
        {
            return _context.Chars.Any(e => e.Charid == id);
        }
    }
}
