using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Models.External;
using Naja.ViewModels;

namespace Naja.Controllers
{
    public class AuctionHouseController : Controller
    {
        private readonly XidbContext _context;

        public AuctionHouseController(XidbContext context)
        {
            _context = context;
        }

        // GET: AuctionHouse
        public async Task<IActionResult> Index()
        {
            var auctionHouse = await _context.AuctionHouses
                .Where(ah => ah.SellDate == 0)
                .Include(ah => ah.ItemBasic)
                .GroupBy(ah => new { ah.Itemid, ah.Stack })
                .Select(static g => new AuctionHouseViewModel
                {
                    ItemId = g.Key.Itemid,
                    SortName = g.FirstOrDefault()!.ItemBasic.Sortname.Replace("_", " "),
                    Quantity = g.Key.Stack == 1 ? g.FirstOrDefault()!.ItemBasic.StackSize : (byte)1,
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
