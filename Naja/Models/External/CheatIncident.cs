using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CheatIncident
{
    public uint Charid { get; set; }

    public DateTime IncidentTime { get; set; }

    public uint Cheatid { get; set; }

    public uint Cheatarg { get; set; }

    public string? Description { get; set; }
}
