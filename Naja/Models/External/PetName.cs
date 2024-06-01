using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class PetName
{
    public ushort Id { get; set; }

    public string Name { get; set; } = null!;
}
