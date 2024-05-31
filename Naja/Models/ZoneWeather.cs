using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class ZoneWeather
{
    public short Zone { get; set; }

    public byte[]? Weather { get; set; }
}
