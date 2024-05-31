using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Linkshell
{
    public uint Linkshellid { get; set; }

    public string Name { get; set; } = null!;

    public ushort Color { get; set; }

    public string Poster { get; set; } = null!;

    public byte[]? Message { get; set; }

    public uint Messagetime { get; set; }

    public byte Postrights { get; set; }

    public byte Broken { get; set; }
}
