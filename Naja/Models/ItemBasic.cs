using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemBasic
{
    public ItemUsable? ItemUsable { get; set; }
    public ItemEquipment? ItemEquipment { get; set; }
    public ItemWeapon? ItemWeapon { get; set; }
    public ItemFurnishing? ItemFurnishing { get; set; }
    public ItemPuppet? ItemPuppet { get; set; }

    [NotMapped]
    public required List<string> ListFlags { get; set; }
    [NotMapped]
    public required string AhCategory { get; set; }
    [NotMapped]
    public bool Sellable { get; set; }
}