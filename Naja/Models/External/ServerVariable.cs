using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ServerVariable
{
    public string Name { get; set; } = null!;

    public int Value { get; set; }

    public int Expiry { get; set; }
}
