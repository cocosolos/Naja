using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class AuditGm
{
    public DateTime DateTime { get; set; }

    public string GmName { get; set; } = null!;

    public string Command { get; set; } = null!;

    public string FullString { get; set; } = null!;
}
