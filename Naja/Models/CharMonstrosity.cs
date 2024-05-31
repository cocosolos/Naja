using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharMonstrosity
{
    public uint Charid { get; set; }

    public ushort CurrentMonstrosityId { get; set; }

    public ushort CurrentMonstrositySpecies { get; set; }

    public ushort CurrentMonstrosityNamePrefix1 { get; set; }

    public ushort CurrentMonstrosityNamePrefix2 { get; set; }

    public uint CurrentExp { get; set; }

    public byte[]? Equip { get; set; }

    public byte[]? Levels { get; set; }

    public byte[]? Instincts { get; set; }

    public byte[]? Variants { get; set; }

    public byte Belligerency { get; set; }

    public float EntryX { get; set; }

    public float EntryY { get; set; }

    public float EntryZ { get; set; }

    public byte EntryRot { get; set; }

    public ushort EntryZoneId { get; set; }

    public byte EntryMjob { get; set; }

    public byte EntrySjob { get; set; }
}
