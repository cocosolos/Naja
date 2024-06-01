using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharHistory
{
    public uint Charid { get; set; }

    public uint EnemiesDefeated { get; set; }

    public uint TimesKnockedOut { get; set; }

    public uint MhEntrances { get; set; }

    public uint JoinedParties { get; set; }

    public uint JoinedAlliances { get; set; }

    public uint SpellsCast { get; set; }

    public uint AbilitiesUsed { get; set; }

    public uint WsUsed { get; set; }

    public uint ItemsUsed { get; set; }

    public uint ChatsSent { get; set; }

    public uint NpcInteractions { get; set; }

    public uint BattlesFought { get; set; }

    public uint GmCalls { get; set; }

    public uint DistanceTravelled { get; set; }
}
