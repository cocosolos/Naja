using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemWeapon
{
    public ushort ItemId { get; set; }

    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public string? Name { get; set; }

    public byte Skill { get; set; }

    [NotMapped]
    private static readonly Dictionary<int, string> SkillMappings = new Dictionary<int, string>
    {
        { 0, "None" },
        { 1, "Hand To Hand" },
        { 2, "Dagger" },
        { 3, "Sword" },
        { 4, "Great Sword" },
        { 5, "Axe" },
        { 6, "Great Axe" },
        { 7, "Scythe" },
        { 8, "Polearm" },
        { 9, "Katana" },
        { 10, "Great Katana" },
        { 11, "Club" },
        { 12, "Staff" },
        { 25, "Archery" },
        { 26, "Marksmanship" },
        { 27, "Throwing" },
        { 41, "String Instrument" },
        { 42, "Wind Instrument" },
        { 45, "Handbell" },
        { 48, "Fishing" }
    };

    [NotMapped]
    public string SkillDescription
    {
        get
        {
            string description = "Unknown";
            if (SkillMappings.TryGetValue(Skill, out string? tempDescription))
            {
                description = tempDescription!;
            }
            return description;
        }
    }

    public sbyte Subskill { get; set; }

    public short IlvlSkill { get; set; }

    public short IlvlParry { get; set; }

    public short IlvlMacc { get; set; }

    public uint DmgType { get; set; }

    [NotMapped]
    public string DmgTypeDescription
    {
        get
        {
            switch (DmgType)
            {
                case 1:
                    return "Piercing";
                case 2:
                    return "Slashing";
                case 3:
                    return "Blunt (Impact)";
                case 4:
                    return "Blunt (Hand to Hand)";
                default:
                    return "Unknown";
            }
        }
    }

    public byte Hit { get; set; }

    public int Delay { get; set; }

    public uint Dmg { get; set; }

    public short UnlockPoints { get; set; }
}
