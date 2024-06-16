using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Naja.Models.External;
using Naja.Services;
using Naja.ViewModels;

namespace Naja
{
    public class YellsController : Controller
    {
        private readonly XidbContext _context;
        private readonly IChatService _chatService;
        private readonly IAccountService _accountService;

        public YellsController(XidbContext context, IChatService chatService, IAccountService accountService)
        {
            _context = context;
            _chatService = chatService;
            _accountService = accountService;
        }

        // GET: Yells
        public async Task<IActionResult> Index(int? count, int? page)
        {
            var defaultCount = 25;
            ViewData["count"] = count;

            var chats = _context.AuditChats
            .Where(c => c.Type == "YELL")
            .Select(chat => new ChatViewModel
            {
                Chat = chat,
                Message = _chatService.ConvertBlobToString(chat.Message),
            })
            .OrderBy(x => x.Chat.Datetime)
            .AsNoTracking();

            var totalPages = await chats.CountAsync();
            var lastPage = (int)Math.Ceiling(totalPages / (double)(count ?? defaultCount));
            return View(await PaginatedList<ChatViewModel>.CreateAsync(chats, page ?? lastPage, count ?? defaultCount));
        }

        // GET: Yells/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _accountService.GetCurrentCharacter();

            if (character == null || character.Gmlevel < 1)
            {
                return Unauthorized();
            }

            var yellToDelete = await _context.AuditChats
                .Where(c => c.LineId == id)
                .Select(y => new ChatViewModel
                {
                    Chat = y,
                    Message = _chatService.ConvertBlobToString(y.Message)
                })
                .FirstOrDefaultAsync();
            if (yellToDelete == null)
            {
                return NotFound();
            }

            return View(yellToDelete);
        }

        // POST: Yells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _accountService.GetCurrentCharacter();

            if (character == null || character.Gmlevel < 1)
            {
                return Unauthorized();
            }

            var yellToDelete = await _context.AuditChats
                .FirstOrDefaultAsync(c => c.LineId == id);

            if (yellToDelete != null)
            {
                _context.AuditChats.Remove(yellToDelete);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
