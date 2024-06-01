using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class MobSkillList
{
    public string? SkillListName { get; set; }

    public ushort SkillListId { get; set; }

    public ushort MobSkillId { get; set; }
}
