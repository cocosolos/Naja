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

using Naja.Models.External;
using Naja.Services;
using Naja.ViewModels;

namespace Naja
{
    [Route("Account/Characters")]
    [Authorize]
    public class AccountCharactersController : Controller
    {
        private readonly XidbContext _context;
        private readonly IAccountService _accountService;
        private readonly ICharacterService _characterService;
        private readonly IClientResourcesService _clientResourceService;

        public AccountCharactersController(XidbContext context, IAccountService accountService, ICharacterService characterService, IClientResourcesService clientResourceService)
        {
            _context = context;
            _accountService = accountService;
            _characterService = characterService;
            _clientResourceService = clientResourceService;
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

            var characters = await _accountService.GetCharacters();

            var charViewModels = new List<CharViewModel>();
            if (characters != null)
            {
                foreach (var character in characters)
                {
                    charViewModels.Add(new CharViewModel
                    {
                        Character = character,
                        ZoneName = _clientResourceService.GetAttribute("zones", character.PosZone, "en"),
                        NationName = _clientResourceService.GetAttribute("regions", character.Nation, "en"),
                        NationImageUrl = _characterService.GetNationImageUrl(character.Nation)
                    });
                }
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
            var characters = await _accountService.GetCharacters();
            var character = characters?.Where(c => c.Charid == id).FirstOrDefault();
            if (character == null)
            {
                return NotFound();
            }

            var claimsPrincipal = HttpContext.User;

            if (claimsPrincipal.Identity is ClaimsIdentity currentClaimsIdentity)
            {
                var existingCharacterIdClaim = currentClaimsIdentity.FindFirst("CharacterId");

                if (existingCharacterIdClaim != null)
                {
                    currentClaimsIdentity.RemoveClaim(existingCharacterIdClaim);
                }

                currentClaimsIdentity.AddClaim(new Claim("CharacterId", character.Charid.ToString()));

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

            var characters = await _accountService.GetCharacters();
            if (characters?.Where(c => c.Charid == id).FirstOrDefault() == null)
            {
                return Unauthorized();
            }

            var character = _context.Chars
                .Include(c => c.Inventory)
                .ThenInclude(i => i.Item)
                .FirstOrDefault(c => c.Charid == id);
            if (character == null)
            {
                return NotFound();
            }

            var viewModel = new CharViewModel
            {
                Character = character,
                ZoneName = _clientResourceService.GetAttribute("zones", character.PosZone, "en"),
                NationName = _clientResourceService.GetAttribute("regions", character.Nation, "en"),
                NationImageUrl = _characterService.GetNationImageUrl(character.Nation),
                Gil = _characterService.GetGil(character.Charid)
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
