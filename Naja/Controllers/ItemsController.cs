using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Models;
using Naja.ViewModels;
using Naja.Models.External;
using Naja.Services;

namespace Naja.Controllers
{
    public class ItemsController : Controller
    {
        private readonly XidbContext _context;
        private readonly IItemService _itemService;
        private readonly IClientResourcesService _clientResourcesService;

        public ItemsController(XidbContext context, IItemService itemService, IClientResourcesService clientResourcesService)
        {
            _context = context;
            _itemService = itemService;
            _clientResourcesService = clientResourcesService;
        }

        // GET: Items
        public async Task<IActionResult> Index(string sort,
            string search,
            int? page)
        {
            ViewData["CurrentSort"] = sort;
            ViewData["SearchParam"] = search;
            ViewData["NameSortParam"] = sort == "name" ? "name_desc" : sort == "name_desc" ? "" : "name";

            var items = _context.ItemBasics.Select(item => new ItemViewModel
            {
                Basic = item,
                DisplayName = _clientResourcesService.GetAttribute("items", item.Itemid, "en"),
                Description = _clientResourcesService.GetAttribute("item_descriptions", item.Itemid, "en"),
            });

            if (!String.IsNullOrEmpty(search))
            {
                search = search.Replace(" ", "_").Replace("'", "");
                items = items.Where(s => s.Basic.Name.Contains(search) || s.Basic.Sortname.Contains(search));
            }

            switch (sort)
            {
                case "name_desc":
                    items = items.OrderByDescending(s => s.Basic.Sortname);
                    break;
                case "name":
                    items = items.OrderBy(s => s.Basic.Sortname);
                    break;
                case "itemid_desc":
                    items = items.OrderByDescending(s => s.Basic.Itemid);
                    break;
                default:
                    items = items.OrderBy(s => s.Basic.Itemid);
                    break;
            }
            int pageSize = 100;
            return View(await PaginatedList<ItemViewModel>.CreateAsync(items.AsNoTracking(), page ?? 1, pageSize));
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
