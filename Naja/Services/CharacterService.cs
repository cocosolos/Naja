using Microsoft.EntityFrameworkCore;

using Naja.Models.External;

namespace Naja.Services;

public interface ICharacterService
{
    uint GetGil(uint characterId);
    string GetNationImageUrl(byte nationId);
}

public class CharacterService : ICharacterService
{
    private readonly XidbContext _context;
    private readonly IClientResourcesService _clientResourceService;

    public CharacterService(XidbContext context, IClientResourcesService clientResourceService)
    {
        _context = context;
        _clientResourceService = clientResourceService;
    }

    public uint GetGil(uint characterId)
    {
        var character = _context.Chars
            .Include(c => c.Inventory)
            .FirstOrDefault(c => c.Charid == characterId);

        if (character == null)
        {
            return 0;
        }

        var gilItem = character.Inventory.FirstOrDefault(i => i.ItemId == 65535);
        return gilItem?.Quantity ?? 0;
    }

    public string GetNationImageUrl(byte nationId)
    {
        switch (nationId)
        {
            case 0:
                return "/images/sandoria.png";
            case 1:
                return "/images/bastok.png";
            case 2:
                return "/images/windurst.png";
            default:
                return "/images/monster.png";
        }
    }
}
