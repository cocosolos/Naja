using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class SkillchainDamageModifier
{
    public string ChainLevel { get; set; } = null!;

    public string ChainCount { get; set; } = null!;

    public int InitialModifier { get; set; }

    public int MagicBurstModifier { get; set; }
}
