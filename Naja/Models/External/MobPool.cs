using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class MobPool
{
    public uint Poolid { get; set; }

    public string? Name { get; set; }

    public string? PacketName { get; set; }

    public ushort Familyid { get; set; }

    public byte[] Modelid { get; set; } = null!;

    public byte MJob { get; set; }

    public byte SJob { get; set; }

    public byte CmbSkill { get; set; }

    public ushort CmbDelay { get; set; }

    public ushort CmbDmgMult { get; set; }

    public ushort Behavior { get; set; }

    public byte Aggro { get; set; }

    public byte TrueDetection { get; set; }

    public byte Links { get; set; }

    public ushort MobType { get; set; }

    public int Immunity { get; set; }

    public byte NamePrefix { get; set; }

    public uint Flag { get; set; }

    public uint EntityFlags { get; set; }

    public bool Animationsub { get; set; }

    public byte HasSpellScript { get; set; }

    public short SpellList { get; set; }

    public sbyte Namevis { get; set; }

    public ushort Roamflag { get; set; }

    public ushort SkillListId { get; set; }

    public ushort ResistId { get; set; }
}
