using Microsoft.EntityFrameworkCore;

using Naja.Models.External;

public interface IAccountService
{
    uint? GetAccountId();
    uint? GetCharacterId();
    string? GetCharacterName();
    Task<ICollection<Naja.Models.External.Char>?> GetCharacters();
}

public class AccountService : IAccountService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly XidbContext _context;

    public enum StatusCodes : byte
    {
        Normal = 0x01,
        Banned = 0x02
    }
    public enum FeatureCodes : byte
    {
        SecureToken = 0x0001,
        UnusedFeature1 = 0x0002,
        MogWardrobe3 = 0x0004,
        MogWardrobe4 = 0x0008,
        MogWardrobe5 = 0x0010,
        MogWardrobe6 = 0x0020,
        MogWardrobe7 = 0x0040,
        MogWardrobe8 = 0x0080,
    }
    public enum PrivilegeCodes : byte
    {
        User = 0x01,
        Admin = 0x02,
        Root = 0x04
    }

    public AccountService(IHttpContextAccessor httpContextAccessor, XidbContext context)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public uint? GetAccountId()
    {
        var accountIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst("AccountId")?.Value;
        if (uint.TryParse(accountIdClaim, out uint accountId))
        {
            return accountId;
        }
        return null;
    }

    public uint? GetCharacterId()
    {
        var characterIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst("CharacterId")?.Value;
        if (uint.TryParse(characterIdClaim, out uint characterId))
        {
            return characterId;
        }
        return null;
    }

    public string? GetCharacterName()
    {
        return _httpContextAccessor.HttpContext?.User.FindFirst("CharacterName")?.Value;
    }

    public async Task<ICollection<Naja.Models.External.Char>?> GetCharacters()
    {
        var accountId = GetAccountId();
        return await _context.Accounts
                .Where(a => a.Id == accountId)
                .Select(a => a.Characters)
                .AsNoTracking()
                .FirstOrDefaultAsync();
    }
}