using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemWeapon
{
    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    [NotMapped]
    public required string SkillName { get; set; }
    [NotMapped]
    public required string DamageType { get; set; }
}