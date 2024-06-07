using Naja.Models.External;

namespace Naja.Services;

public class CharacterService
{
    private readonly XidbContext _context;
    private readonly IClientResourcesService _clientResourceService;

    public CharacterService(XidbContext context, IClientResourcesService clientResourceService)
    {
        _context = context;
        _clientResourceService = clientResourceService;
    }

    public string GetCurrentZoneName(ushort zoneId)
    {
        return _clientResourceService.GetAttribute("zones", zoneId, "en");
    }

    public string GetNationName(byte nationId)
    {
        switch (nationId)
        {
            case 0:
                return "San d'Oria";
            case 1:
                return "Bastok";
            case 2:
                return "Windurst";
            default:
                return "Monster";
        }
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
