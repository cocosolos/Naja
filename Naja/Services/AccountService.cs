using Naja.Models.External;

public class AccountService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AccountService(IHttpContextAccessor httpContextAccessor)
    {
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
}