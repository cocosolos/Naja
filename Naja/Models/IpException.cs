﻿using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class IpException
{
    public uint Accid { get; set; }

    public DateTime Exception { get; set; }

    public string? Comment { get; set; }
}
