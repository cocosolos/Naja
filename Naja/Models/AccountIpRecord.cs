using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class AccountIpRecord
{
    public DateTime LoginTime { get; set; }

    public int Accid { get; set; }

    public int Charid { get; set; }

    public string ClientIp { get; set; } = null!;
}
