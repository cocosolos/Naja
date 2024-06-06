using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemWeapon
{
    [ForeignKey("ItemId")]
    public required ItemEquipment ItemEquipment { get; set; }

    [NotMapped]
    public required string SkillName { get; set; }
    [NotMapped]
    public required string DamageType { get; set; }
}