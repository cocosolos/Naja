using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class PetSkill
{
    public ushort PetSkillId { get; set; }

    public ushort PetAnimId { get; set; }

    public string PetSkillName { get; set; } = null!;

    public byte PetSkillAoe { get; set; }

    public float PetSkillDistance { get; set; }

    public ushort PetAnimTime { get; set; }

    public ushort PetPrepareTime { get; set; }

    public ushort PetValidTargets { get; set; }

    public ushort PetMessage { get; set; }

    public byte PetSkillFlag { get; set; }

    public short PetSkillParam { get; set; }

    public short PetSkillFinishCategory { get; set; }

    public bool Knockback { get; set; }

    public sbyte PrimarySc { get; set; }

    public sbyte SecondarySc { get; set; }

    public sbyte TertiarySc { get; set; }
}
