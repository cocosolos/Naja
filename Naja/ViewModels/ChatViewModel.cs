using Naja.Models.External;

namespace Naja.ViewModels;

public class ChatViewModel
{
    public required AuditChat Chat { get; set; }
    public required string Message { get; set; }
}