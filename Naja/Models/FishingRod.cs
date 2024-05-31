using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class FishingRod
{
    public uint Rodid { get; set; }

    public string Name { get; set; } = null!;

    public byte Material { get; set; }

    public byte SizeType { get; set; }

    public uint Flags { get; set; }

    public ushort MinRank { get; set; }

    public ushort MaxRank { get; set; }

    public byte FishAttack { get; set; }

    public byte LgdBonusAttack { get; set; }

    public byte FishRecovery { get; set; }

    public byte FishTime { get; set; }

    public byte LgdBonusTime { get; set; }

    public byte SmDelayBonus { get; set; }

    public byte SmMoveBonus { get; set; }

    public byte LgDelayBonus { get; set; }

    public byte LgMoveBonus { get; set; }

    public byte Multiplier { get; set; }

    public byte Breakable { get; set; }

    public uint BrokenRodid { get; set; }

    public byte Mmm { get; set; }

    public byte Legendary { get; set; }

    public byte Rating { get; set; }
}
