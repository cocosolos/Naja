using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        private readonly CharService _charService;

        public AccountCharactersController(XiContext context, CharService charService)
        {
            _context = context;
            _charService = charService;
        }

        // GET: Account/Characters
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null)
            {
                return Unauthorized();
            }

            var chars = await _context.Chars.Where(c => c.Accid == uint.Parse(accountId)).ToListAsync();

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

        // GET: Account/Character/5/Details
        [HttpGet("{id}/Details")]
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null)
            {
                return Unauthorized();
            }

            var character = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == uint.Parse(accountId));
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
            var accountId = User.FindFirst("AccountId")?.Value;
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
            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid)
            {
                newChar.Accid = uint.Parse(accountId);
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

            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null)
            {
                return Unauthorized();
            }

            var charToEdit = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == uint.Parse(accountId));
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

            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null || charToEdit.Accid != uint.Parse(accountId))
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

            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null)
            {
                return Unauthorized();
            }

            var charToDelete = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == uint.Parse(accountId));
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
            var accountId = User.FindFirst("AccountId")?.Value;
            if (accountId == null)
            {
                return Unauthorized();
            }

            var charToDelete = await _context.Chars
                .Include(c => c.Account)
                .FirstOrDefaultAsync(c => c.Charid == id && c.Accid == uint.Parse(accountId));

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
