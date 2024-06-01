using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class SynthRecipe
{
    public uint Id { get; set; }

    public byte Desynth { get; set; }

    public uint KeyItem { get; set; }

    public byte Wood { get; set; }

    public byte Smith { get; set; }

    public byte Gold { get; set; }

    public byte Cloth { get; set; }

    public byte Leather { get; set; }

    public byte Bone { get; set; }

    public byte Alchemy { get; set; }

    public byte Cook { get; set; }

    public ushort Crystal { get; set; }

    public ushort Hqcrystal { get; set; }

    public ushort Ingredient1 { get; set; }

    public ushort Ingredient2 { get; set; }

    public ushort Ingredient3 { get; set; }

    public ushort Ingredient4 { get; set; }

    public ushort Ingredient5 { get; set; }

    public ushort Ingredient6 { get; set; }

    public ushort Ingredient7 { get; set; }

    public ushort Ingredient8 { get; set; }

    public ushort Result { get; set; }

    public ushort ResultHq1 { get; set; }

    public ushort ResultHq2 { get; set; }

    public ushort ResultHq3 { get; set; }

    public byte ResultQty { get; set; }

    public byte ResultHq1qty { get; set; }

    public byte ResultHq2qty { get; set; }

    public byte ResultHq3qty { get; set; }

    public string ResultName { get; set; } = null!;
}
