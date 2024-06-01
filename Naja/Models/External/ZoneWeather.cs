using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ZoneWeather
{
    public short Zone { get; set; }

    public byte[]? Weather { get; set; }
}
