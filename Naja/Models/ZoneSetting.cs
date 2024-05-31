using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class ZoneSetting
{
    public ushort Zoneid { get; set; }

    public ushort Zonetype { get; set; }

    public string Zoneip { get; set; } = null!;

    public ushort Zoneport { get; set; }

    public string Name { get; set; } = null!;

    public byte MusicDay { get; set; }

    public byte MusicNight { get; set; }

    public byte Battlesolo { get; set; }

    public byte Battlemulti { get; set; }

    public byte Restriction { get; set; }

    public float Tax { get; set; }

    public ushort Misc { get; set; }
}
