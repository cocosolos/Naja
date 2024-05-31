using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharProfile
{
    public uint Charid { get; set; }

    public uint RankPoints { get; set; }

    public byte RankSandoria { get; set; }

    public byte RankBastok { get; set; }

    public byte RankWindurst { get; set; }

    public ushort FameSandoria { get; set; }

    public ushort FameBastok { get; set; }

    public ushort FameWindurst { get; set; }

    public ushort FameNorg { get; set; }

    public ushort FameJeuno { get; set; }

    public ushort FameAbyKonschtat { get; set; }

    public ushort FameAbyTahrongi { get; set; }

    public ushort FameAbyLatheine { get; set; }

    public ushort FameAbyMisareaux { get; set; }

    public ushort FameAbyVunkerl { get; set; }

    public ushort FameAbyAttohwa { get; set; }

    public ushort FameAbyAltepa { get; set; }

    public ushort FameAbyGrauberg { get; set; }

    public ushort FameAbyUleguerand { get; set; }

    public ushort FameAdoulin { get; set; }

    public byte UnityLeader { get; set; }
}
