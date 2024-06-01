using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class AccountsParty
{
    public uint Charid { get; set; }

    public uint Partyid { get; set; }

    public ushort Partyflag { get; set; }

    public uint Allianceid { get; set; }

    public DateTime Timestamp { get; set; }

    public virtual AccountsSession Char { get; set; } = null!;
}
