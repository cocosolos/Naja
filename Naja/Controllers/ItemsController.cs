using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Models;
using Naja.ViewModels;
using Naja.Models.External;

namespace Naja.Controllers
{
    public class ItemsController : Controller
    {
        private readonly XidbContext _context;
        private readonly IItemService _itemService;
        public ItemsController(XidbContext context, IItemService itemService)
        {
            _context = context;
            _itemService = itemService;
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

            var items = _context.ItemBasics.Select(item => item);

            if (!String.IsNullOrEmpty(search))
            {
                items = items.Where(s => s.Name.Contains(search.Replace("_", " ")) || s.Sortname.Contains(search.Replace("_", " ")));
            }

            // items = items.Select(item => new ItemViewModel
            // {
            //     ItemBasic = item.ItemBasic,
            //     Name = item.Name.ToTitleCaseWithRomanNumerals(),
            //     SortName = item.SortName.ToTitleCaseWithRomanNumerals(),
            // });

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
        public async Task<IActionResult> Details(ushort id)
        {
            var viewModel = await _itemService.GetItemViewModel(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

    }
}
