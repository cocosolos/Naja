using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models;

public partial class Char
{
    public uint Charid { get; set; }

    public uint Accid { get; set; }

    [ForeignKey("Accid")]
    public virtual required Account Account { get; set; }

    public uint OriginalAccid { get; set; }

    public string Charname { get; set; } = null!;

    public byte Nation { get; set; }

    public ushort PosZone { get; set; }

    public ushort PosPrevzone { get; set; }

    public byte PosRot { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public uint Moghouse { get; set; }

    public ushort Boundary { get; set; }

    public ushort HomeZone { get; set; }

    public byte HomeRot { get; set; }

    public float HomeX { get; set; }

    public float HomeY { get; set; }

    public float HomeZ { get; set; }

    public byte[]? Missions { get; set; }

    public byte[]? Assault { get; set; }

    public byte[]? Campaign { get; set; }

    public byte[]? Eminence { get; set; }

    public byte[]? Quests { get; set; }

    public byte[]? Keyitems { get; set; }

    public byte[]? SetBlueSpells { get; set; }

    public byte[]? Abilities { get; set; }

    public byte[]? Weaponskills { get; set; }

    public byte[]? Titles { get; set; }

    public byte[]? Zones { get; set; }

    public uint Playtime { get; set; }

    public byte[]? UnlockedWeapons { get; set; }

    public ushort Gmlevel { get; set; }

    public byte? Languages { get; set; }

    public short Mentor { get; set; }

    public byte JobMaster { get; set; }

    public byte CampaignAllegiance { get; set; }

    public bool Isstylelocked { get; set; }

    public ulong Settings { get; set; }

    public ulong Chatfilters1 { get; set; }

    public ulong Chatfilters2 { get; set; }

    public ushort Moghancement { get; set; }

    public DateTime Timecreated { get; set; }

    public DateTime Lastupdate { get; set; }
}
