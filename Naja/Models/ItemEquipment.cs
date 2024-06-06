using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemEquipment
{
    [ForeignKey("ItemId")]
    public required ItemBasic ItemBasic { get; set; }
    public ItemWeapon? ItemWeapon { get; set; }


    [NotMapped]
    public required List<string> ListJobs { get; set; }
    [NotMapped]
    public required List<string> ListSlots { get; set; }
}