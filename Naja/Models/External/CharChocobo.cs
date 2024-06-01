using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharChocobo
{
    public uint Charid { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool Sex { get; set; }

    public DateTime Created { get; set; }

    public byte LastUpdateAge { get; set; }

    public byte Stage { get; set; }

    public byte Location { get; set; }

    public byte Colour { get; set; }

    public byte DominantGene { get; set; }

    public byte RecessiveGene { get; set; }

    public byte Strength { get; set; }

    public byte Endurance { get; set; }

    public byte Discernment { get; set; }

    public byte Receptivity { get; set; }

    public byte Affection { get; set; }

    public byte Energy { get; set; }

    public byte Satisfaction { get; set; }

    public uint Conditions { get; set; }

    public byte Ability1 { get; set; }

    public byte Ability2 { get; set; }

    public byte Personality { get; set; }

    public byte WeatherPreference { get; set; }

    public byte Hunger { get; set; }

    public uint CarePlan { get; set; }

    public uint HeldItem { get; set; }
}
