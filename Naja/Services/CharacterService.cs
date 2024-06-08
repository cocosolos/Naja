using Naja.Models.External;

namespace Naja.Services;

public interface ICharacterService
{
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
