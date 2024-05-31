using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharLook
{
    public uint Charid { get; set; }

    public byte Face { get; set; }

    public byte Race { get; set; }

    public byte Size { get; set; }

    public ushort Head { get; set; }

    public ushort Body { get; set; }

    public ushort Hands { get; set; }

    public ushort Legs { get; set; }

    public ushort Feet { get; set; }

    public ushort Main { get; set; }

    public ushort Sub { get; set; }

    public ushort Ranged { get; set; }
}
