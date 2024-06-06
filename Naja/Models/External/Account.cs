using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class Account
{
    public uint Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string CurrentEmail { get; set; } = null!;

    public string RegistrationEmail { get; set; } = null!;

    public DateTime Timecreate { get; set; }

    public DateTime Timelastmodify { get; set; }

    public byte ContentIds { get; set; }

    public ushort Expansions { get; set; }

    public byte Features { get; set; }

    public byte Status { get; set; }

    public byte Priv { get; set; }
}
