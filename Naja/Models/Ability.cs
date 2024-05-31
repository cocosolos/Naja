using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Ability
{
    public ushort AbilityId { get; set; }

    public string? Name { get; set; }

    public byte Job { get; set; }

    public byte Level { get; set; }

    public ushort ValidTarget { get; set; }

    public ushort RecastTime { get; set; }

    public ushort RecastId { get; set; }

    public ushort Message1 { get; set; }

    public ushort Message2 { get; set; }

    public ushort Animation { get; set; }

    public ushort AnimationTime { get; set; }

    public ushort CastTime { get; set; }

    public byte ActionType { get; set; }

    public float Range { get; set; }

    public byte IsAoe { get; set; }

    public short Ce { get; set; }

    public short Ve { get; set; }

    public short MeritModId { get; set; }

    public short AddType { get; set; }

    public string? ContentTag { get; set; }
}
