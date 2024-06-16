using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Models.External;
using Naja.Services;
using Naja.ViewModels;

namespace Naja.Controllers
{
    public class AuctionHouseController : Controller
    {
        private readonly XidbContext _context;
        private readonly IClientResourcesService _clientResourcesService;

        public AuctionHouseController(XidbContext context, IClientResourcesService clientResourcesService)
        {
            _context = context;
            _clientResourcesService = clientResourcesService;
        }

        // GET: AuctionHouse
        public async Task<IActionResult> Index(int? page)
        {
            var auctionHouse = _context.AuctionHouses
                .Where(ah => ah.SellDate == 0)
                .Include(ah => ah.Item)
                .GroupBy(ah => new { ah.Itemid, ah.Stack })
                .Select(g => new AuctionHouseViewModel
                {
                    ItemId = g.Key.Itemid,
                    DisplayName = _clientResourcesService.GetAttribute("items", g.Key.Itemid, "en"),
                    Quantity = g.Key.Stack == 1 ? g.FirstOrDefault()!.Item.StackSize : (byte)1,
                    Stack = g.Key.Stack,
                    Stock = g.Count(),
                    LatestDate = g.Max(ah => ah.Date),
                    Listings = g.ToList()
                })
                .OrderByDescending(g => g.LatestDate);

            int pageSize = 50;
            return View(await PaginatedList<AuctionHouseViewModel>.CreateAsync(auctionHouse.AsNoTracking(), page ?? 1, pageSize));

        }

    }
}
