using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MonstrositySpecy
{
    public ushort MonstrosityId { get; set; }

    public ushort MonstrositySpeciesCode { get; set; }

    public string? Name { get; set; }

    public byte Mjob { get; set; }

    public byte Sjob { get; set; }

    public byte Size { get; set; }

    public byte[] Look { get; set; } = null!;
}
