using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemEquipment
{
    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    [NotMapped]
    public required List<string> ListJobs { get; set; }
    [NotMapped]
    public required List<string> ListSlots { get; set; }
}