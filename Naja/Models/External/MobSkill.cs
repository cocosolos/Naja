using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class MobSkill
{
    public ushort MobSkillId { get; set; }

    public ushort MobAnimId { get; set; }

    public string MobSkillName { get; set; } = null!;

    public byte MobSkillAoe { get; set; }

    public float MobSkillDistance { get; set; }

    public ushort MobAnimTime { get; set; }

    public ushort MobPrepareTime { get; set; }

    public ushort MobValidTargets { get; set; }

    public byte MobSkillFlag { get; set; }

    public short MobSkillParam { get; set; }

    public bool Knockback { get; set; }

    public sbyte PrimarySc { get; set; }

    public sbyte SecondarySc { get; set; }

    public sbyte TertiarySc { get; set; }
}
