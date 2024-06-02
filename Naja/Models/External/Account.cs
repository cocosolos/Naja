using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class Account
{
    [Key]
    public uint Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? CurrentEmail { get; set; } = null!;

    public string? RegistrationEmail { get; set; } = null!;

    public DateTime Timecreate { get; set; }

    public DateTime Timelastmodify { get; set; }

    public byte ContentIds { get; set; }

    [Flags]
    public enum ExpansionCodes : ushort
    {
        BaseGame = 0x0001,
        RiseOfZilart = 0x0002,
        ChainsOfPromathia = 0x0004,
        TreasuresOfAhtUrghan = 0x0008,
        WingsOfTheGoddess = 0x0010,
        ACrystallineProphecy = 0x0020,
        AMoogleKupodEtat = 0x0040,
        AShantottoAscension = 0x0080,
        VisionsOfAbyssea = 0x0100,
        ScarsOfAbyssea = 0x0200,
        HeroesOfAbyssea = 0x0400,
        SeekersOfAdoulin = 0x0800,
        UnusedExpansion1 = 0x1000,
        UnusedExpansion2 = 0x2000,
        UnusedExpansion3 = 0x4000,
        UnusedExpansion4 = 0x8000,
    }

    public ExpansionCodes Expansions { get; set; }

    [Flags]
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

    public FeatureCodes Features { get; set; }

    public enum StatusCodes : byte
    {
        Normal = 0x01,
        Banned = 0x02
    }

    public StatusCodes Status { get; set; }

    public enum PrivilegeCodes : byte
    {
        User = 0x01,
        Admin = 0x02,
        Root = 0x04
    }

    public PrivilegeCodes Priv { get; set; }

    [NotMapped]
    public ICollection<Char> Chars { get; set; } = new List<Char>();
}
