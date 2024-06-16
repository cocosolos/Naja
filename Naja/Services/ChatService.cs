using System.Text;

using Microsoft.EntityFrameworkCore;

using Naja.Models.External;
using Naja.ViewModels;

namespace Naja.Services;

public interface IChatService
{
    Task<IEnumerable<ChatViewModel>> GetYells(int count);
    string ConvertBlobToString(byte[]? message);
}

public class ChatService : IChatService
{
    private readonly XidbContext _context;
    private readonly IClientResourcesService _clientResourceService;

    private enum AutoTranslateOp : ushort
    {
        Term = 0x02,
        Item = 0x07,
        KeyItem = 0x13
    }

    public ChatService(XidbContext context, IClientResourcesService clientResourceService)
    {
        _context = context;
        _clientResourceService = clientResourceService;
    }
    public async Task<IEnumerable<ChatViewModel>> GetYells(int count)
    {
        var yells = await _context.AuditChats
            .Where(c => c.Type == "YELL")
            .OrderBy(y => y.Datetime)
            .Take(count)
            .AsNoTracking()
            .ToListAsync();

        var chatViewModels = yells.Select(chat => new ChatViewModel
        {
            Chat = chat,
            Message = ConvertBlobToString(chat.Message)
        }).ToList();

        return chatViewModels;
    }

    public string ConvertBlobToString(byte[]? message)
    {
        if (message == null || message.Length == 0)
        {
            return string.Empty;
        }

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Encoding encoding = Encoding.GetEncoding("shift_jis");

        var result = new StringBuilder();

        int i = 0;
        while (i < message.Length)
        {
            if (message[i] == 0xFD)
            {
                if (i + 4 < message.Length)
                {
                    string autoString;
                    AutoTranslateOp op = (AutoTranslateOp)message[i + 1];
                    ushort id = (ushort)((message[i + 3] << 8) | message[i + 4]);

                    if (op == AutoTranslateOp.Term)
                    {
                        autoString = _clientResourceService.GetAttribute("auto_translates", id, "en");
                        result.Append($"{(char)message[i]}{autoString}{(char)message[i + 5]}");
                    }
                    else if (op == AutoTranslateOp.Item)
                    {
                        autoString = _clientResourceService.GetAttribute("items", id, "en");
                        // TODO: Come up with a way to convey that this is an item without including the HTML here. Handle linking in the view script section.
                        result.Append($"{(char)message[i]}<a href=\"/Items/Details/{id}\" class=\"text-reset\">{autoString}</a>{(char)message[i + 5]}");
                    }
                    else if (op == AutoTranslateOp.KeyItem)
                    {
                        autoString = _clientResourceService.GetAttribute("key_items", id, "en");
                        result.Append($"{(char)message[i]}{autoString}{(char)message[i + 5]}");
                    }

                    i += 5;
                }
                else
                {
                    result.Append(encoding.GetString(new byte[] { message[i] }));
                }
            }
            else
            {
                int byteCount = 1;
                if ((message[i] >= 0x81 && message[i] <= 0x9F) || (message[i] >= 0xE0 && message[i] <= 0xFC))
                {
                    if (i + 1 < message.Length)
                    {
                        byteCount = 2; // This is a multi-byte character
                    }
                }

                result.Append(encoding.GetString(message, i, byteCount));
                i += byteCount - 1; // Move forward by the number of bytes processed minus 1 because of the increment in the loop
            }

            i++;
        }

        return result.ToString();
    }

}