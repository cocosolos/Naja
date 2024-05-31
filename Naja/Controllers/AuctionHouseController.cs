using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Naja.Models;

namespace Naja.Controllers
{
    public class AuctionHouseController : Controller
    {
        private readonly XiContext _context;

        public AuctionHouseController(XiContext context)
        {
            _context = context;
        }

        // GET: AuctionHouse
        public async Task<IActionResult> Index()
        {
            var auctionHouse = await _context.AuctionHouse
                .Where(ah => ah.SellDate == 0)
                .Include(a => a.ItemBasic)
                .ToListAsync();

            var groupedAuctionHouse = auctionHouse
                .GroupBy(ah => new ValueTuple<ushort, byte>(ah.Itemid, ah.Stack))
                .Select(g => new
                {
                    Group = g,
                    LatestDate = g.Max(ah => ah.Date)
                })
                .OrderByDescending(g => g.LatestDate)
                .Select(g => g.Group)
                .ToList();

            return View(groupedAuctionHouse);
        }

    }
}
