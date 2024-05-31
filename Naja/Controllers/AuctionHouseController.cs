using Microsoft.AspNetCore.Mvc;
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
                .Include(ah => ah.ItemBasic)
                .GroupBy(ah => new { ah.Itemid, ah.Stack })
                .Select(g => new AuctionHouseViewModel
                {
                    ItemId = g.Key.Itemid,
                    Stack = g.Key.Stack,
                    Stock = g.Count(),
                    LatestDate = g.Max(ah => ah.Date),
                    Listings = g.ToList()
                })
                .OrderByDescending(g => g.LatestDate)
                .ToListAsync();

            return View(auctionHouse);
        }

    }
}
