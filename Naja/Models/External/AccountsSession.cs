using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class AccountsSession
{
    public uint Accid { get; set; }

    public uint Charid { get; set; }

    public ushort Targid { get; set; }

    public uint Unitychat { get; set; }

    public uint Linkshellid1 { get; set; }

    public ushort Linkshellrank1 { get; set; }

    public uint Linkshellid2 { get; set; }

    public ushort Linkshellrank2 { get; set; }

    public byte[] SessionKey { get; set; } = null!;

    public uint ServerAddr { get; set; }

    public ushort ServerPort { get; set; }

    public uint ClientAddr { get; set; }

    public ushort ClientPort { get; set; }

    public byte VersionMismatch { get; set; }

    public byte SeacomType { get; set; }

    public byte[]? SeacomMessage { get; set; }

    public virtual AccountsParty? AccountsParty { get; set; }
}
