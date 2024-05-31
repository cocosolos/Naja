using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models;

public partial class ItemEquipment
{
    public ushort ItemId { get; set; }

    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public string? Name { get; set; }

    public byte Level { get; set; }

    public byte Ilevel { get; set; }

    public uint Jobs { get; set; }

    [NotMapped]
    private static readonly Dictionary<int, string> JobMappings = new Dictionary<int, string>
    {
      {  0, "WAR" },
      {  1, "MNK" },
      {  2, "WHM" },
      {  3, "BLM" },
      {  4, "RDM" },
      {  5, "THF" },
      {  6, "PLD" },
      {  7, "DRK" },
      {  8, "BST" },
      {  9, "BRD" },
      { 10, "RNG" },
      { 11, "SAM" },
      { 12, "NIN" },
      { 13, "DRG" },
      { 14, "SMN" },
      { 15, "BLU" },
      { 16, "COR" },
      { 17, "PUP" },
      { 18, "DNC" },
      { 19, "SCH" },
      { 20, "GEO" },
      { 21, "RUN" },
    };

    [NotMapped]
    public List<string> JobDescriptions
    {
        get
        {
            if (Jobs == 0)
                return new List<string>(["None"]);

            var appliedJobs = new List<string>();

            foreach (var job in JobMappings)
            {
                if ((Jobs & (uint)Math.Pow(2, job.Key)) != 0)
                {
                    appliedJobs.Add(job.Value);
                }
            }

            return appliedJobs.Count() == JobMappings.Count() ? ["All Jobs"] : appliedJobs;
        }
    }

    public ushort Mid { get; set; }

    public byte ShieldSize { get; set; }

    public ushort ScriptType { get; set; }

    public ushort Slot { get; set; }

    [NotMapped]
    private static readonly Dictionary<int, string> SlotMappings = new Dictionary<int, string>
    {
        { 0, "Main" },
        { 1, "Sub" },
        { 2, "Ranged" },
        { 3, "Ammo" },
        { 4, "Head" },
        { 5, "Body" },
        { 6, "Hands" },
        { 7, "Legs" },
        { 8, "Feet" },
        { 9, "Neck" },
        { 10, "Waist" },
        { 11, "Earring1" },
        { 12, "Earring2" },
        { 13, "Ring1" },
        { 14, "Ring2" },
        { 15, "Back" }
    };

    [NotMapped]
    public List<string> SlotDescriptions
    {

        get
        {
            if (Slot == 0)
                return new List<string>(["None"]);

            var validSlots = new List<string>();

            foreach (var slot in SlotMappings)
            {
                if ((Slot & (uint)Math.Pow(2, slot.Key)) != 0)
                {
                    validSlots.Add(slot.Value);
                }
            }

            return validSlots;
        }
    }

    public ushort Rslot { get; set; }

    public byte SuLevel { get; set; }
}
