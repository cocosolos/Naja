using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using Naja.Models.External;
using Naja.Services;

namespace Naja
{
    public class YellsController : Controller
    {
        private readonly IChatService _chatService;

        public YellsController(IChatService chatService)
        {
            _chatService = chatService;
        }

        // GET: Yells
        public async Task<IActionResult> Index(int count)
        {
            var chats = await _chatService.GetYells(count);

            return View(chats);
        }
    }
}
