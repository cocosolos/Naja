﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemFurnishing
{
    [ForeignKey("Itemid")]
    public required ItemBasic ItemBasic { get; set; }
}
