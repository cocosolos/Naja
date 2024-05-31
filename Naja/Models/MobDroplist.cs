using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MobDroplist
{
    public ushort DropId { get; set; }

    public byte DropType { get; set; }

    public byte GroupId { get; set; }

    public ushort GroupRate { get; set; }

    public ushort ItemId { get; set; }

    public ushort ItemRate { get; set; }
}
