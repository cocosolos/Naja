using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ItemWeapon
{
    public ushort ItemId { get; set; }

    public string? Name { get; set; }

    public byte Skill { get; set; }

    public sbyte Subskill { get; set; }

    public short IlvlSkill { get; set; }

    public short IlvlParry { get; set; }

    public short IlvlMacc { get; set; }

    public uint DmgType { get; set; }

    public byte Hit { get; set; }

    public int Delay { get; set; }

    public uint Dmg { get; set; }

    public short UnlockPoints { get; set; }
}
