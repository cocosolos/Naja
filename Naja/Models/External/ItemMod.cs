﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemMod
{
    public ushort ItemId { get; set; }

    public ushort ModId { get; set; }

    public short Value { get; set; }
}
