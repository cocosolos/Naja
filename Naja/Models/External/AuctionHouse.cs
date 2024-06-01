using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class AuctionHouse
{
    public uint Id { get; set; }

    [ForeignKey("ItemBasic")]
    public ushort Itemid { get; set; }

    public virtual required ItemBasic ItemBasic { get; set; }

    public byte Stack { get; set; }

    [NotMapped]
    public byte Amount => Stack == 1 ? ItemBasic.StackSize : (byte)(1);

    public uint Seller { get; set; }

    public string? SellerName { get; set; }

    public uint Date { get; set; }

    [NotMapped]
    public DateTime DateDt
    {
        get
        {
            return DateTimeOffset.FromUnixTimeSeconds(Date).UtcDateTime;
        }
    }

    public uint Price { get; set; }

    public string? BuyerName { get; set; }

    public uint Sale { get; set; }

    public uint SellDate { get; set; }

    [NotMapped]
    public DateTime SellDateDt
    {
        get
        {
            return DateTimeOffset.FromUnixTimeSeconds(SellDate).UtcDateTime;
        }
    }
}
