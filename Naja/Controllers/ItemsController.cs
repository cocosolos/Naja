using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Models;

namespace Naja.Controllers
{
    public class ItemsController : Controller
    {
        private readonly XiContext _context;

        public ItemsController(XiContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index(string sort,
            string search,
            int? page)
        {
            ViewData["CurrentSort"] = sort;
            ViewData["SearchParam"] = search;
            ViewData["NameSortParam"] = sort == "name" ? "name_desc" : sort == "name_desc" ? "" : "name";
            ViewData["SortnameSortParam"] = sort == "sortname" ? "sortname_desc" : sort == "sortname_desc" ? "" : "sortname";

            var items = _context.ItemsBasic.Select(item => item);

            if (!String.IsNullOrEmpty(search))
            {
                var searchFormatted = search.Replace(" ", "_");
                items = items.Where(s => s.Name.Contains(searchFormatted) || s.Sortname.Contains(searchFormatted));
            }
            switch (sort)
            {
                case "name_desc":
                    items = items.OrderByDescending(s => s.Name);
                    break;
                case "name":
                    items = items.OrderBy(s => s.Name);
                    break;
                case "sortname_desc":
                    items = items.OrderByDescending(s => s.Sortname);
                    break;
                case "sortname":
                    items = items.OrderBy(s => s.Sortname);
                    break;
                case "itemid_desc":
                    items = items.OrderByDescending(s => s.Itemid);
                    break;
                default:
                    items = items.OrderBy(s => s.Itemid);
                    break;
            }
            int pageSize = 100;
            return View(await PaginatedList<ItemBasic>.CreateAsync(items.AsNoTracking(), page ?? 1, pageSize));
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(ushort? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.ItemsBasic
                .Include(b => b.ItemUsable)
                .Include(b => b.ItemEquipment)
                .Include(b => b.ItemWeapon)
                .Include(b => b.ItemFurnishing)
                .Include(b => b.ItemPuppet)
                .FirstOrDefaultAsync(m => m.Itemid == id);

            if (item == null)
            {
                return NotFound();
            }

            var auctionHouseHistory = await _context.AuctionHouse
                .Where(ah => ah.Itemid == id && ah.SellDate != 0)
                .OrderByDescending(ah => ah.Date)
                .ToListAsync();

            var auctionHouseStock = await _context.AuctionHouse
                .Where(ah => ah.Itemid == id && ah.SellDate == 0)
                .GroupBy(ah => ah.Stack)
                .Select(g => new
                {
                    Stack = g.Key,
                    Count = g.Count()
                })
                .ToListAsync();

            int singlesCount = auctionHouseStock.FirstOrDefault(g => g.Stack == 0)?.Count ?? 0;
            int stacksCount = auctionHouseStock.FirstOrDefault(g => g.Stack == 1)?.Count ?? 0;

            var viewModel = new ItemViewModel
            {
                ItemBasic = item,
                AuctionHouseHistory = auctionHouseHistory,
                AuctionHouseStock = (singlesCount, stacksCount)
            };

            return View(viewModel);
        }

    }
}
