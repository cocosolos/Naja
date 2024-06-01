using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

using Naja.Models.External;

namespace Naja.Data;

public partial class XiContext : DbContext
{
    public XiContext()
    {
    }

    public XiContext(DbContextOptions<XiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbilitiesCharge> AbilitiesCharges { get; set; }

    public virtual DbSet<Ability> Abilities { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountIpRecord> AccountIpRecords { get; set; }

    public virtual DbSet<AccountsBanned> AccountsBanneds { get; set; }

    public virtual DbSet<AccountsParty> AccountsParties { get; set; }

    public virtual DbSet<AccountsSession> AccountsSessions { get; set; }

    public virtual DbSet<AuctionHouse> AuctionHouse { get; set; }

    public virtual DbSet<AuctionHouseItem> AuctionHouseItems { get; set; }

    public virtual DbSet<AuditChat> AuditChats { get; set; }

    public virtual DbSet<AuditGm> AuditGms { get; set; }

    public virtual DbSet<Augment> Augments { get; set; }

    public virtual DbSet<AutomatonAbility> AutomatonAbilities { get; set; }

    public virtual DbSet<AutomatonSpell> AutomatonSpells { get; set; }

    public virtual DbSet<BcnmBattlefield> BcnmBattlefields { get; set; }

    public virtual DbSet<BcnmInfo> BcnmInfos { get; set; }

    public virtual DbSet<BcnmTreasureChest> BcnmTreasureChests { get; set; }

    public virtual DbSet<BlueSpellList> BlueSpellLists { get; set; }

    public virtual DbSet<BlueSpellMod> BlueSpellMods { get; set; }

    public virtual DbSet<BlueTrait> BlueTraits { get; set; }

    public virtual DbSet<CampaignMap> CampaignMaps { get; set; }

    public virtual DbSet<CampaignNation> CampaignNations { get; set; }

    public virtual DbSet<Models.External.Char> Chars { get; set; }

    public virtual DbSet<CharBlacklist> CharBlacklists { get; set; }

    public virtual DbSet<CharChocobo> CharChocobos { get; set; }

    public virtual DbSet<CharEffect> CharEffects { get; set; }

    public virtual DbSet<CharEquip> CharEquips { get; set; }

    public virtual DbSet<CharEquipSaved> CharEquipSaveds { get; set; }

    public virtual DbSet<CharExp> CharExps { get; set; }

    public virtual DbSet<CharFlag> CharFlags { get; set; }

    public virtual DbSet<CharHistory> CharHistories { get; set; }

    public virtual DbSet<CharInventory> CharInventories { get; set; }

    public virtual DbSet<CharJob> CharJobs { get; set; }

    public virtual DbSet<CharJobPoint> CharJobPoints { get; set; }

    public virtual DbSet<CharLook> CharLooks { get; set; }

    public virtual DbSet<CharMerit> CharMerits { get; set; }

    public virtual DbSet<CharMonstrosity> CharMonstrosities { get; set; }

    public virtual DbSet<CharPet> CharPets { get; set; }

    public virtual DbSet<CharPoint> CharPoints { get; set; }

    public virtual DbSet<CharProfile> CharProfiles { get; set; }

    public virtual DbSet<CharRecast> CharRecasts { get; set; }

    public virtual DbSet<CharSkill> CharSkills { get; set; }

    public virtual DbSet<CharSpell> CharSpells { get; set; }

    public virtual DbSet<CharStat> CharStats { get; set; }

    public virtual DbSet<CharStorage> CharStorages { get; set; }

    public virtual DbSet<CharStyle> CharStyles { get; set; }

    public virtual DbSet<CharUnlock> CharUnlocks { get; set; }

    public virtual DbSet<CharVar> CharVars { get; set; }

    public virtual DbSet<CheatIncident> CheatIncidents { get; set; }

    public virtual DbSet<CheatType> CheatTypes { get; set; }

    public virtual DbSet<ConquestSystem> ConquestSystems { get; set; }

    public virtual DbSet<DeliveryBox> DeliveryBoxes { get; set; }

    public virtual DbSet<DespoilEffect> DespoilEffects { get; set; }

    public virtual DbSet<ExpBase> ExpBases { get; set; }

    public virtual DbSet<ExpTable> ExpTables { get; set; }

    public virtual DbSet<FishingArea> FishingAreas { get; set; }

    public virtual DbSet<FishingBait> FishingBaits { get; set; }

    public virtual DbSet<FishingBaitAffinity> FishingBaitAffinities { get; set; }

    public virtual DbSet<FishingCatch> FishingCatches { get; set; }

    public virtual DbSet<FishingFish> FishingFishes { get; set; }

    public virtual DbSet<FishingGroup> FishingGroups { get; set; }

    public virtual DbSet<FishingMob> FishingMobs { get; set; }

    public virtual DbSet<FishingRod> FishingRods { get; set; }

    public virtual DbSet<FishingZone> FishingZones { get; set; }

    public virtual DbSet<GardeningResult> GardeningResults { get; set; }

    public virtual DbSet<Guild> Guilds { get; set; }

    public virtual DbSet<GuildItemPoint> GuildItemPoints { get; set; }

    public virtual DbSet<GuildShop> GuildShops { get; set; }

    public virtual DbSet<InstanceEntity> InstanceEntities { get; set; }

    public virtual DbSet<InstanceList> InstanceLists { get; set; }

    public virtual DbSet<IpException> IpExceptions { get; set; }

    public virtual DbSet<ItemBasic> ItemsBasic { get; set; }

    public virtual DbSet<ItemEquipment> ItemsEquipment { get; set; }

    public virtual DbSet<ItemFurnishing> ItemsFurnishing { get; set; }

    public virtual DbSet<ItemLatent> ItemsLatent { get; set; }

    public virtual DbSet<ItemMod> ItemsMod { get; set; }

    public virtual DbSet<ItemModsPet> ItemsModsPet { get; set; }

    public virtual DbSet<ItemPuppet> ItemsPuppet { get; set; }

    public virtual DbSet<ItemUsable> ItemsUsable { get; set; }

    public virtual DbSet<ItemWeapon> ItemsWeapon { get; set; }

    public virtual DbSet<JobPoint> JobPoints { get; set; }

    public virtual DbSet<JobPointGift> JobPointGifts { get; set; }

    public virtual DbSet<Linkshell> Linkshells { get; set; }

    public virtual DbSet<Merit> Merits { get; set; }

    public virtual DbSet<MobDroplist> MobDroplists { get; set; }

    public virtual DbSet<MobFamilyMod> MobFamilyMods { get; set; }

    public virtual DbSet<MobFamilySystem> MobFamilySystems { get; set; }

    public virtual DbSet<MobGroup> MobGroups { get; set; }

    public virtual DbSet<MobPet> MobPets { get; set; }

    public virtual DbSet<MobPool> MobPools { get; set; }

    public virtual DbSet<MobPoolMod> MobPoolMods { get; set; }

    public virtual DbSet<MobResistance> MobResistances { get; set; }

    public virtual DbSet<MobSkill> MobSkills { get; set; }

    public virtual DbSet<MobSkillList> MobSkillLists { get; set; }

    public virtual DbSet<MobSpawnMod> MobSpawnMods { get; set; }

    public virtual DbSet<MobSpawnPoint> MobSpawnPoints { get; set; }

    public virtual DbSet<MobSpellList> MobSpellLists { get; set; }

    public virtual DbSet<MonstrosityExpTable> MonstrosityExpTables { get; set; }

    public virtual DbSet<MonstrosityInstinct> MonstrosityInstincts { get; set; }

    public virtual DbSet<MonstrosityInstinctMod> MonstrosityInstinctMods { get; set; }

    public virtual DbSet<MonstrositySpecy> MonstrositySpecies { get; set; }

    public virtual DbSet<NmSpawnPoint> NmSpawnPoints { get; set; }

    public virtual DbSet<NpcList> NpcLists { get; set; }

    public virtual DbSet<PetList> PetLists { get; set; }

    public virtual DbSet<PetName> PetNames { get; set; }

    public virtual DbSet<PetSkill> PetSkills { get; set; }

    public virtual DbSet<ServerVariable> ServerVariables { get; set; }

    public virtual DbSet<SkillCap> SkillCaps { get; set; }

    public virtual DbSet<SkillRank> SkillRanks { get; set; }

    public virtual DbSet<SkillchainDamageModifier> SkillchainDamageModifiers { get; set; }

    public virtual DbSet<SpellList> SpellLists { get; set; }

    public virtual DbSet<StatusEffect> StatusEffects { get; set; }

    public virtual DbSet<SynthRecipe> SynthRecipes { get; set; }

    public virtual DbSet<Trait> Traits { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<UnitySystem> UnitySystems { get; set; }

    public virtual DbSet<WaterPoint> WaterPoints { get; set; }

    public virtual DbSet<WeaponSkill> WeaponSkills { get; set; }

    public virtual DbSet<ZoneSetting> ZoneSettings { get; set; }

    public virtual DbSet<ZoneWeather> ZoneWeathers { get; set; }

    public virtual DbSet<Zoneline> Zonelines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AbilitiesCharge>(entity =>
        {
            entity.HasKey(e => new { e.RecastId, e.Job, e.Level })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("abilities_charges");

            entity.Property(e => e.RecastId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("recastId");
            entity.Property(e => e.Job)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("job");
            entity.Property(e => e.Level)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.ChargeTime)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("chargeTime");
            entity.Property(e => e.MaxCharges)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("maxCharges");
            entity.Property(e => e.MeritModId)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("meritModID");
        });

        modelBuilder.Entity<Ability>(entity =>
        {
            entity.HasKey(e => e.AbilityId).HasName("PRIMARY");

            entity.ToTable("abilities");

            entity.Property(e => e.AbilityId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("abilityId");
            entity.Property(e => e.ActionType)
                .HasDefaultValueSql("'6'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("actionType");
            entity.Property(e => e.AddType)
                .HasColumnType("smallint(2)")
                .HasColumnName("addType");
            entity.Property(e => e.Animation)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("animation");
            entity.Property(e => e.AnimationTime)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("animationTime");
            entity.Property(e => e.CastTime)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("castTime");
            entity.Property(e => e.Ce)
                .HasColumnType("smallint(5)")
                .HasColumnName("CE");
            entity.Property(e => e.ContentTag)
                .HasMaxLength(7)
                .HasColumnName("content_tag");
            entity.Property(e => e.IsAoe)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("isAOE");
            entity.Property(e => e.Job)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("job");
            entity.Property(e => e.Level)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.MeritModId)
                .HasColumnType("smallint(4)")
                .HasColumnName("meritModID");
            entity.Property(e => e.Message1)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("message1");
            entity.Property(e => e.Message2)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("message2");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.Range)
                .HasColumnType("float(3,1) unsigned")
                .HasColumnName("range");
            entity.Property(e => e.RecastId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("recastId");
            entity.Property(e => e.RecastTime)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("recastTime");
            entity.Property(e => e.ValidTarget)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("validTarget");
            entity.Property(e => e.Ve)
                .HasColumnType("smallint(5)")
                .HasColumnName("VE");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("accounts");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ContentIds)
                .HasDefaultValueSql("'16'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("content_ids");
            entity.Property(e => e.CurrentEmail)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("current_email");
            entity.Property(e => e.Expansions)
                .HasDefaultValueSql("'4094'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("expansions");
            entity.Property(e => e.Features)
                .HasDefaultValueSql("'253'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("features");
            entity.Property(e => e.Login)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Priv)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("priv");
            entity.Property(e => e.RegistrationEmail)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("registration_email");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("status");
            entity.Property(e => e.Timecreate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("timecreate");
            entity.Property(e => e.Timelastmodify)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("timelastmodify");
        });

        modelBuilder.Entity<AccountIpRecord>(entity =>
        {
            entity.HasKey(e => new { e.LoginTime, e.Accid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("account_ip_record");

            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("login_time");
            entity.Property(e => e.Accid)
                .HasColumnType("int(10)")
                .HasColumnName("accid");
            entity.Property(e => e.Charid)
                .HasColumnType("int(10)")
                .HasColumnName("charid");
            entity.Property(e => e.ClientIp)
                .HasColumnType("tinytext")
                .HasColumnName("client_ip");
        });

        modelBuilder.Entity<AccountsBanned>(entity =>
        {
            entity.HasKey(e => e.Accid).HasName("PRIMARY");

            entity.ToTable("accounts_banned");

            entity.Property(e => e.Accid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("accid");
            entity.Property(e => e.Banncomment)
                .HasMaxLength(512)
                .HasColumnName("banncomment");
            entity.Property(e => e.Timebann)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("timebann");
            entity.Property(e => e.Timeunbann)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("timeunbann");
        });

        modelBuilder.Entity<AccountsParty>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("accounts_parties");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Allianceid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("allianceid");
            entity.Property(e => e.Partyflag)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("partyflag");
            entity.Property(e => e.Partyid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("partyid");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Char).WithOne(p => p.AccountsParty)
                .HasForeignKey<AccountsParty>(d => d.Charid)
                .HasConstraintName("accounts_parties_ibfk_1");
        });

        modelBuilder.Entity<AccountsSession>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("accounts_sessions");

            entity.HasIndex(e => e.Accid, "accid").IsUnique();

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Accid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("accid");
            entity.Property(e => e.ClientAddr)
                .HasDefaultValueSql("'0000000000'")
                .HasColumnType("int(10) unsigned zerofill")
                .HasColumnName("client_addr");
            entity.Property(e => e.ClientPort)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("client_port");
            entity.Property(e => e.Linkshellid1)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("linkshellid1");
            entity.Property(e => e.Linkshellid2)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("linkshellid2");
            entity.Property(e => e.Linkshellrank1)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("linkshellrank1");
            entity.Property(e => e.Linkshellrank2)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("linkshellrank2");
            entity.Property(e => e.SeacomMessage)
                .HasColumnType("tinyblob")
                .HasColumnName("seacom_message");
            entity.Property(e => e.SeacomType)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("seacom_type");
            entity.Property(e => e.ServerAddr)
                .HasDefaultValueSql("'0000000000'")
                .HasColumnType("int(10) unsigned zerofill")
                .HasColumnName("server_addr");
            entity.Property(e => e.ServerPort)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("server_port");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(20)
                .HasDefaultValueSql("'\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0\\\\0'")
                .IsFixedLength()
                .HasColumnName("session_key");
            entity.Property(e => e.Targid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("targid");
            entity.Property(e => e.Unitychat)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("unitychat");
            entity.Property(e => e.VersionMismatch)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("version_mismatch");
        });

        modelBuilder.Entity<AuctionHouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("auction_house");

            entity.HasIndex(e => e.Seller, "charid");

            entity.HasIndex(e => e.Itemid, "itemid");

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(15)
                .HasColumnName("buyer_name");
            entity.Property(e => e.Date)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date");
            entity.Property(e => e.Itemid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Price)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("price");
            entity.Property(e => e.Sale)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sale");
            entity.Property(e => e.SellDate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sell_date");
            entity.Property(e => e.Seller)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("seller");
            entity.Property(e => e.SellerName)
                .HasMaxLength(15)
                .HasColumnName("seller_name");
            entity.Property(e => e.Stack)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("stack");
        });

        modelBuilder.Entity<AuctionHouseItem>(entity =>
        {
            entity.HasKey(e => e.Itemid).HasName("PRIMARY");

            entity.ToTable("auction_house_items");

            entity.Property(e => e.Itemid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
        });

        modelBuilder.Entity<AuditChat>(entity =>
        {
            entity.HasKey(e => e.LineId).HasName("PRIMARY");

            entity.ToTable("audit_chat");

            entity.Property(e => e.LineId)
                .HasColumnType("int(10)")
                .HasColumnName("lineID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.LsName)
                .HasColumnType("tinytext")
                .HasColumnName("lsName");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.Recipient)
                .HasColumnType("tinytext")
                .HasColumnName("recipient");
            entity.Property(e => e.Speaker)
                .HasColumnType("tinytext")
                .HasColumnName("speaker");
            entity.Property(e => e.Type)
                .HasColumnType("tinytext")
                .HasColumnName("type");
        });

        modelBuilder.Entity<AuditGm>(entity =>
        {
            entity.HasKey(e => new { e.DateTime, e.GmName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("audit_gm");

            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.GmName)
                .HasMaxLength(16)
                .HasColumnName("gm_name");
            entity.Property(e => e.Command)
                .HasMaxLength(40)
                .HasColumnName("command");
            entity.Property(e => e.FullString)
                .HasMaxLength(200)
                .HasColumnName("full_string");
        });

        modelBuilder.Entity<Augment>(entity =>
        {
            entity.HasKey(e => new { e.AugmentId, e.Multiplier, e.ModId, e.IsPet, e.PetType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("augments");

            entity.Property(e => e.AugmentId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("augmentId");
            entity.Property(e => e.Multiplier)
                .HasColumnType("smallint(2)")
                .HasColumnName("multiplier");
            entity.Property(e => e.ModId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modId");
            entity.Property(e => e.IsPet).HasColumnName("isPet");
            entity.Property(e => e.PetType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("petType");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<AutomatonAbility>(entity =>
        {
            entity.HasKey(e => e.Abilityid).HasName("PRIMARY");

            entity.ToTable("automaton_abilities");

            entity.Property(e => e.Abilityid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("abilityid");
            entity.Property(e => e.Abilityname)
                .HasMaxLength(40)
                .HasColumnName("abilityname")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Reqframe)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("reqframe");
            entity.Property(e => e.Skilllevel)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("skilllevel");
        });

        modelBuilder.Entity<AutomatonSpell>(entity =>
        {
            entity.HasKey(e => e.Spellid).HasName("PRIMARY");

            entity.ToTable("automaton_spells");

            entity.Property(e => e.Spellid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("spellid");
            entity.Property(e => e.Enfeeble)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("enfeeble");
            entity.Property(e => e.Heads)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("heads");
            entity.Property(e => e.Immunity)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("immunity");
            entity.Property(e => e.Removes)
                .HasColumnType("int(6) unsigned")
                .HasColumnName("removes");
            entity.Property(e => e.Skilllevel)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("skilllevel");
        });

        modelBuilder.Entity<BcnmBattlefield>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bcnm_battlefield");

            entity.Property(e => e.BattlefieldNumber)
                .HasColumnType("tinyint(3)")
                .HasColumnName("battlefieldNumber");
            entity.Property(e => e.BcnmId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("bcnmId");
            entity.Property(e => e.Conditions)
                .HasColumnType("tinyint(2)")
                .HasColumnName("conditions");
            entity.Property(e => e.MonsterId)
                .HasColumnType("int(10)")
                .HasColumnName("monsterId");
        });

        modelBuilder.Entity<BcnmInfo>(entity =>
        {
            entity.HasKey(e => e.BcnmId).HasName("PRIMARY");

            entity.ToTable("bcnm_info");

            entity.Property(e => e.BcnmId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("bcnmId");
            entity.Property(e => e.FastestName)
                .HasMaxLength(15)
                .HasDefaultValueSql("'Not Set!'")
                .HasColumnName("fastestName");
            entity.Property(e => e.FastestPartySize)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("fastestPartySize");
            entity.Property(e => e.FastestTime)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fastestTime");
            entity.Property(e => e.IsMission)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("isMission");
            entity.Property(e => e.LevelCap)
                .HasDefaultValueSql("'75'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("levelCap");
            entity.Property(e => e.LootDropId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("lootDropId");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.PartySize)
                .HasDefaultValueSql("'6'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("partySize");
            entity.Property(e => e.Rules)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rules");
            entity.Property(e => e.TimeLimit)
                .HasDefaultValueSql("'1800'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("timeLimit");
            entity.Property(e => e.ZoneId)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("zoneId");
        });

        modelBuilder.Entity<BcnmTreasureChest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bcnm_treasure_chests");

            entity.Property(e => e.BattlefieldNumber)
                .HasColumnType("tinyint(3)")
                .HasColumnName("battlefieldNumber");
            entity.Property(e => e.BcnmId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("bcnmId");
            entity.Property(e => e.NpcId)
                .HasColumnType("int(10)")
                .HasColumnName("npcId");
        });

        modelBuilder.Entity<BlueSpellList>(entity =>
        {
            entity.HasKey(e => new { e.Spellid, e.MobSkillId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("blue_spell_list");

            entity.Property(e => e.Spellid)
                .HasColumnType("smallint(3)")
                .HasColumnName("spellid");
            entity.Property(e => e.MobSkillId)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mob_skill_id");
            entity.Property(e => e.PrimarySc)
                .HasColumnType("smallint(2)")
                .HasColumnName("primary_sc");
            entity.Property(e => e.SecondarySc)
                .HasColumnType("smallint(2)")
                .HasColumnName("secondary_sc");
            entity.Property(e => e.SetPoints)
                .HasColumnType("smallint(2)")
                .HasColumnName("set_points");
            entity.Property(e => e.TertiarySc)
                .HasColumnType("smallint(2)")
                .HasColumnName("tertiary_sc");
            entity.Property(e => e.TraitCategory)
                .HasColumnType("smallint(2)")
                .HasColumnName("trait_category");
            entity.Property(e => e.TraitCategoryWeight)
                .HasColumnType("smallint(2)")
                .HasColumnName("trait_category_weight");
        });

        modelBuilder.Entity<BlueSpellMod>(entity =>
        {
            entity.HasKey(e => new { e.SpellId, e.Modid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("blue_spell_mods");

            entity.Property(e => e.SpellId)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("spellId");
            entity.Property(e => e.Modid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modid");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<BlueTrait>(entity =>
        {
            entity.HasKey(e => new { e.TraitCategory, e.TraitPointsNeeded, e.Modifier })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("blue_traits");

            entity.Property(e => e.TraitCategory)
                .HasColumnType("smallint(2) unsigned")
                .HasColumnName("trait_category");
            entity.Property(e => e.TraitPointsNeeded)
                .HasColumnType("smallint(2) unsigned")
                .HasColumnName("trait_points_needed");
            entity.Property(e => e.Modifier)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modifier");
            entity.Property(e => e.Traitid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("traitid");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CampaignMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("campaign_map");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CurrentFortifications)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("current_fortifications");
            entity.Property(e => e.CurrentResources)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("current_resources");
            entity.Property(e => e.Heroism)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("heroism");
            entity.Property(e => e.InfluenceBastok)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("influence_bastok");
            entity.Property(e => e.InfluenceBeastman)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("influence_beastman");
            entity.Property(e => e.InfluenceSandoria)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("influence_sandoria");
            entity.Property(e => e.InfluenceWindurst)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("influence_windurst");
            entity.Property(e => e.Isbattle)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("isbattle");
            entity.Property(e => e.MaxFortifications)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("max_fortifications");
            entity.Property(e => e.MaxResources)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("max_resources");
            entity.Property(e => e.Nation)
                .HasDefaultValueSql("'8'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("nation");
            entity.Property(e => e.Zoneid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("zoneid");
        });

        modelBuilder.Entity<CampaignNation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("campaign_nation");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Morale)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("morale");
            entity.Property(e => e.Prosperity)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("prosperity");
            entity.Property(e => e.Reconnaissance)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("reconnaissance");
        });

        modelBuilder.Entity<Models.External.Char>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("chars");

            entity.HasIndex(e => e.Charname, "charname").HasAnnotation("MySql:FullTextIndex", true);

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Abilities)
                .HasColumnType("blob")
                .HasColumnName("abilities");
            entity.Property(e => e.Accid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("accid");
            entity.Property(e => e.Assault)
                .HasColumnType("blob")
                .HasColumnName("assault");
            entity.Property(e => e.Boundary)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("boundary");
            entity.Property(e => e.Campaign)
                .HasColumnType("blob")
                .HasColumnName("campaign");
            entity.Property(e => e.CampaignAllegiance)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("campaign_allegiance");
            entity.Property(e => e.Charname)
                .HasMaxLength(15)
                .HasColumnName("charname");
            entity.Property(e => e.Chatfilters1)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("chatfilters_1");
            entity.Property(e => e.Chatfilters2)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("chatfilters_2");
            entity.Property(e => e.Eminence)
                .HasColumnType("blob")
                .HasColumnName("eminence");
            entity.Property(e => e.Gmlevel)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("gmlevel");
            entity.Property(e => e.HomeRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("home_rot");
            entity.Property(e => e.HomeX)
                .HasColumnType("float(7,3)")
                .HasColumnName("home_x");
            entity.Property(e => e.HomeY)
                .HasColumnType("float(7,3)")
                .HasColumnName("home_y");
            entity.Property(e => e.HomeZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("home_z");
            entity.Property(e => e.HomeZone)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("home_zone");
            entity.Property(e => e.Isstylelocked).HasColumnName("isstylelocked");
            entity.Property(e => e.JobMaster)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("job_master");
            entity.Property(e => e.Keyitems)
                .HasColumnType("blob")
                .HasColumnName("keyitems");
            entity.Property(e => e.Languages)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("languages");
            entity.Property(e => e.Lastupdate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Mentor)
                .HasColumnType("smallint(3)")
                .HasColumnName("mentor");
            entity.Property(e => e.Missions)
                .HasColumnType("blob")
                .HasColumnName("missions");
            entity.Property(e => e.Moghancement)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("moghancement");
            entity.Property(e => e.Moghouse)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("moghouse");
            entity.Property(e => e.Nation)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("nation");
            entity.Property(e => e.OriginalAccid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("original_accid");
            entity.Property(e => e.Playtime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("playtime");
            entity.Property(e => e.PosPrevzone)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("pos_prevzone");
            entity.Property(e => e.PosRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pos_rot");
            entity.Property(e => e.PosX)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_x");
            entity.Property(e => e.PosY)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_y");
            entity.Property(e => e.PosZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_z");
            entity.Property(e => e.PosZone)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("pos_zone");
            entity.Property(e => e.Quests)
                .HasColumnType("blob")
                .HasColumnName("quests");
            entity.Property(e => e.SetBlueSpells)
                .HasColumnType("blob")
                .HasColumnName("set_blue_spells");
            entity.Property(e => e.Settings)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("settings");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("timecreated");
            entity.Property(e => e.Titles)
                .HasColumnType("blob")
                .HasColumnName("titles");
            entity.Property(e => e.UnlockedWeapons)
                .HasColumnType("blob")
                .HasColumnName("unlocked_weapons");
            entity.Property(e => e.Weaponskills)
                .HasColumnType("blob")
                .HasColumnName("weaponskills");
            entity.Property(e => e.Zones)
                .HasColumnType("blob")
                .HasColumnName("zones");
        });

        modelBuilder.Entity<CharBlacklist>(entity =>
        {
            entity.HasKey(e => new { e.CharidTarget, e.CharidOwner })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("char_blacklist");

            entity.Property(e => e.CharidTarget)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid_target");
            entity.Property(e => e.CharidOwner)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid_owner");
        });

        modelBuilder.Entity<CharChocobo>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_chocobos");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Ability1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ability1");
            entity.Property(e => e.Ability2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ability2");
            entity.Property(e => e.Affection)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("affection");
            entity.Property(e => e.CarePlan)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("care_plan");
            entity.Property(e => e.Colour)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("colour");
            entity.Property(e => e.Conditions)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("conditions");
            entity.Property(e => e.Created)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created");
            entity.Property(e => e.Discernment)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("discernment");
            entity.Property(e => e.DominantGene)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dominant_gene");
            entity.Property(e => e.Endurance)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("endurance");
            entity.Property(e => e.Energy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("energy");
            entity.Property(e => e.FirstName)
                .HasMaxLength(15)
                .HasColumnName("first_name");
            entity.Property(e => e.HeldItem)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("held_item");
            entity.Property(e => e.Hunger)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("hunger");
            entity.Property(e => e.LastName)
                .HasMaxLength(15)
                .HasColumnName("last_name");
            entity.Property(e => e.LastUpdateAge)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("last_update_age");
            entity.Property(e => e.Location)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("location");
            entity.Property(e => e.Personality)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("personality");
            entity.Property(e => e.Receptivity)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("receptivity");
            entity.Property(e => e.RecessiveGene)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("recessive_gene");
            entity.Property(e => e.Satisfaction)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("satisfaction");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.Stage)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("stage");
            entity.Property(e => e.Strength)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("strength");
            entity.Property(e => e.WeatherPreference)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("weather_preference");
        });

        modelBuilder.Entity<CharEffect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("char_effects");

            entity.HasIndex(e => e.Charid, "charid");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Duration)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("duration");
            entity.Property(e => e.Effectid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("effectid");
            entity.Property(e => e.Flags)
                .HasColumnType("int(8) unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.Icon)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("icon");
            entity.Property(e => e.Power)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("power");
            entity.Property(e => e.Subid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("subid");
            entity.Property(e => e.Subpower)
                .HasColumnType("smallint(5)")
                .HasColumnName("subpower");
            entity.Property(e => e.Tick)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("tick");
            entity.Property(e => e.Tier)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("tier");
            entity.Property(e => e.Timestamp)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<CharEquip>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Equipslotid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("char_equip");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Equipslotid)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("equipslotid");
            entity.Property(e => e.Containerid)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("containerid");
            entity.Property(e => e.Slotid)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("slotid");
        });

        modelBuilder.Entity<CharEquipSaved>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Jobid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("char_equip_saved");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Jobid)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jobid");
            entity.Property(e => e.Ammo)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ammo");
            entity.Property(e => e.Back)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("back");
            entity.Property(e => e.Body)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("body");
            entity.Property(e => e.Ear1)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ear1");
            entity.Property(e => e.Ear2)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ear2");
            entity.Property(e => e.Feet)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("feet");
            entity.Property(e => e.Hands)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("hands");
            entity.Property(e => e.Head)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("head");
            entity.Property(e => e.Legs)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("legs");
            entity.Property(e => e.Main)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("main");
            entity.Property(e => e.Neck)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("neck");
            entity.Property(e => e.Ranged)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ranged");
            entity.Property(e => e.Ring1)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ring1");
            entity.Property(e => e.Ring2)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ring2");
            entity.Property(e => e.Sub)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("sub");
            entity.Property(e => e.Waist)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("waist");
        });

        modelBuilder.Entity<CharExp>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_exp");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Blm)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("blm");
            entity.Property(e => e.Blu)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("blu");
            entity.Property(e => e.Brd)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("brd");
            entity.Property(e => e.Bst)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("bst");
            entity.Property(e => e.Cor)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("cor");
            entity.Property(e => e.Dnc)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("dnc");
            entity.Property(e => e.Drg)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("drg");
            entity.Property(e => e.Drk)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("drk");
            entity.Property(e => e.Geo)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("geo");
            entity.Property(e => e.Limits)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("limits");
            entity.Property(e => e.Merits)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("merits");
            entity.Property(e => e.Mnk)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("mnk");
            entity.Property(e => e.Mode)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("mode");
            entity.Property(e => e.Nin)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("nin");
            entity.Property(e => e.Pld)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("pld");
            entity.Property(e => e.Pup)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("pup");
            entity.Property(e => e.Rdm)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rdm");
            entity.Property(e => e.Rng)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rng");
            entity.Property(e => e.Run)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("run");
            entity.Property(e => e.Sam)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("sam");
            entity.Property(e => e.Sch)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("sch");
            entity.Property(e => e.Smn)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("smn");
            entity.Property(e => e.Thf)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("thf");
            entity.Property(e => e.War)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("war");
            entity.Property(e => e.Whm)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("whm");
        });

        modelBuilder.Entity<CharFlag>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_flags");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Disconnecting)
                .HasColumnType("smallint(3)")
                .HasColumnName("disconnecting");
            entity.Property(e => e.GmHiddenEnabled)
                .HasColumnType("smallint(3)")
                .HasColumnName("gmHiddenEnabled");
            entity.Property(e => e.GmModeEnabled)
                .HasColumnType("smallint(3)")
                .HasColumnName("gmModeEnabled");
        });

        modelBuilder.Entity<CharHistory>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_history");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.AbilitiesUsed)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("abilities_used");
            entity.Property(e => e.BattlesFought)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("battles_fought");
            entity.Property(e => e.ChatsSent)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("chats_sent");
            entity.Property(e => e.DistanceTravelled)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("distance_travelled");
            entity.Property(e => e.EnemiesDefeated)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("enemies_defeated");
            entity.Property(e => e.GmCalls)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("gm_calls");
            entity.Property(e => e.ItemsUsed)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("items_used");
            entity.Property(e => e.JoinedAlliances)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("joined_alliances");
            entity.Property(e => e.JoinedParties)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("joined_parties");
            entity.Property(e => e.MhEntrances)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mh_entrances");
            entity.Property(e => e.NpcInteractions)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("npc_interactions");
            entity.Property(e => e.SpellsCast)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("spells_cast");
            entity.Property(e => e.TimesKnockedOut)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("times_knocked_out");
            entity.Property(e => e.WsUsed)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ws_used");
        });

        modelBuilder.Entity<CharInventory>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Location, e.Slot })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("char_inventory");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Location)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("location");
            entity.Property(e => e.Slot)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("slot");
            entity.Property(e => e.Bazaar)
                .HasColumnType("int(8) unsigned")
                .HasColumnName("bazaar");
            entity.Property(e => e.Extra)
                .HasColumnType("tinyblob")
                .HasColumnName("extra");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("'65535'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("quantity");
            entity.Property(e => e.Signature)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("signature");
        });

        modelBuilder.Entity<CharJob>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_jobs");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Blm)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("blm");
            entity.Property(e => e.Blu)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("blu");
            entity.Property(e => e.Brd)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("brd");
            entity.Property(e => e.Bst)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("bst");
            entity.Property(e => e.Cor)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("cor");
            entity.Property(e => e.Dnc)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("dnc");
            entity.Property(e => e.Drg)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("drg");
            entity.Property(e => e.Drk)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("drk");
            entity.Property(e => e.Genkai)
                .HasDefaultValueSql("'50'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("genkai");
            entity.Property(e => e.Geo)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("geo");
            entity.Property(e => e.Mnk)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mnk");
            entity.Property(e => e.Nin)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("nin");
            entity.Property(e => e.Pld)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("pld");
            entity.Property(e => e.Pup)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("pup");
            entity.Property(e => e.Rdm)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rdm");
            entity.Property(e => e.Rng)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rng");
            entity.Property(e => e.Run)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("run");
            entity.Property(e => e.Sam)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sam");
            entity.Property(e => e.Sch)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sch");
            entity.Property(e => e.Smn)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("smn");
            entity.Property(e => e.Thf)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("thf");
            entity.Property(e => e.Unlocked)
                .HasDefaultValueSql("'126'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("unlocked");
            entity.Property(e => e.War)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("war");
            entity.Property(e => e.Whm)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("whm");
        });

        modelBuilder.Entity<CharJobPoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("char_job_points");

            entity.HasIndex(e => e.Charid, "char_job_points_charid_index");

            entity.HasIndex(e => new { e.Charid, e.Jobid }, "char_job_points_charid_jobid_index").IsUnique();

            entity.Property(e => e.CapacityPoints)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("capacity_points");
            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.JobPoints)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("job_points");
            entity.Property(e => e.JobPointsSpent)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("job_points_spent");
            entity.Property(e => e.Jobid)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jobid");
            entity.Property(e => e.Jptype0)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype0");
            entity.Property(e => e.Jptype1)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype1");
            entity.Property(e => e.Jptype2)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype2");
            entity.Property(e => e.Jptype3)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype3");
            entity.Property(e => e.Jptype4)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype4");
            entity.Property(e => e.Jptype5)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype5");
            entity.Property(e => e.Jptype6)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype6");
            entity.Property(e => e.Jptype7)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype7");
            entity.Property(e => e.Jptype8)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype8");
            entity.Property(e => e.Jptype9)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("jptype9");
        });

        modelBuilder.Entity<CharLook>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_look");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Body)
                .HasDefaultValueSql("'8'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("body");
            entity.Property(e => e.Face)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("face");
            entity.Property(e => e.Feet)
                .HasDefaultValueSql("'8'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("feet");
            entity.Property(e => e.Hands)
                .HasDefaultValueSql("'8'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("hands");
            entity.Property(e => e.Head)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("head");
            entity.Property(e => e.Legs)
                .HasDefaultValueSql("'8'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("legs");
            entity.Property(e => e.Main)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("main");
            entity.Property(e => e.Race)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("race");
            entity.Property(e => e.Ranged)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("ranged");
            entity.Property(e => e.Size)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("size");
            entity.Property(e => e.Sub)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("sub");
        });

        modelBuilder.Entity<CharMerit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("char_merit");

            entity.HasIndex(e => e.Charid, "char_merits_charid_index");

            entity.HasIndex(e => new { e.Meritid, e.Charid }, "idx_char_merit_meritid_charid").IsUnique();

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Meritid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("meritid");
            entity.Property(e => e.Upgrades)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("upgrades");
        });

        modelBuilder.Entity<CharMonstrosity>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_monstrosity");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Belligerency)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("belligerency");
            entity.Property(e => e.CurrentExp)
                .HasColumnType("int(3) unsigned")
                .HasColumnName("current_exp");
            entity.Property(e => e.CurrentMonstrosityId)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("current_monstrosity_id");
            entity.Property(e => e.CurrentMonstrosityNamePrefix1)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("current_monstrosity_name_prefix_1");
            entity.Property(e => e.CurrentMonstrosityNamePrefix2)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("current_monstrosity_name_prefix_2");
            entity.Property(e => e.CurrentMonstrositySpecies)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("current_monstrosity_species");
            entity.Property(e => e.EntryMjob)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("entry_mjob");
            entity.Property(e => e.EntryRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("entry_rot");
            entity.Property(e => e.EntrySjob)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("entry_sjob");
            entity.Property(e => e.EntryX)
                .HasColumnType("float(7,3)")
                .HasColumnName("entry_x");
            entity.Property(e => e.EntryY)
                .HasColumnType("float(7,3)")
                .HasColumnName("entry_y");
            entity.Property(e => e.EntryZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("entry_z");
            entity.Property(e => e.EntryZoneId)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("entry_zone_id");
            entity.Property(e => e.Equip)
                .HasColumnType("blob")
                .HasColumnName("equip");
            entity.Property(e => e.Instincts)
                .HasColumnType("blob")
                .HasColumnName("instincts");
            entity.Property(e => e.Levels)
                .HasColumnType("blob")
                .HasColumnName("levels");
            entity.Property(e => e.Variants)
                .HasColumnType("blob")
                .HasColumnName("variants");
        });

        modelBuilder.Entity<CharPet>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_pet");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Adventuringfellowid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("adventuringfellowid");
            entity.Property(e => e.Automatonid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("automatonid");
            entity.Property(e => e.Chocoboid)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("chocoboid");
            entity.Property(e => e.EquippedAttachments)
                .HasColumnType("blob")
                .HasColumnName("equipped_attachments");
            entity.Property(e => e.FieldChocobo)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("field_chocobo");
            entity.Property(e => e.UnlockedAttachments)
                .HasColumnType("blob")
                .HasColumnName("unlocked_attachments");
            entity.Property(e => e.Wyvernid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("wyvernid");
        });

        modelBuilder.Entity<CharPoint>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_points");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.AlliedNotes)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("allied_notes");
            entity.Property(e => e.AmanVouchers)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("aman_vouchers");
            entity.Property(e => e.AncientBeastcoin)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ancient_beastcoin");
            entity.Property(e => e.BallistaPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ballista_point");
            entity.Property(e => e.BastokCp)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bastok_cp");
            entity.Property(e => e.Bayld)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("bayld");
            entity.Property(e => e.BeastmanSeal)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("beastman_seal");
            entity.Property(e => e.CavePoints)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("cave_points");
            entity.Property(e => e.ChocobuckBastok)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("chocobuck_bastok");
            entity.Property(e => e.ChocobuckSandoria)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("chocobuck_sandoria");
            entity.Property(e => e.ChocobuckWindurst)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("chocobuck_windurst");
            entity.Property(e => e.Cinder)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cinder");
            entity.Property(e => e.CompressionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("compression_spheres_set");
            entity.Property(e => e.CrafterPoints)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("crafter_points");
            entity.Property(e => e.Cruor)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cruor");
            entity.Property(e => e.CurrentAccolades)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("current_accolades");
            entity.Property(e => e.CurrentHallmarks)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("current_hallmarks");
            entity.Property(e => e.DailyTally)
                .HasDefaultValueSql("-1")
                .HasColumnType("int(10)")
                .HasColumnName("daily_tally");
            entity.Property(e => e.DarkCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dark_crystal_set");
            entity.Property(e => e.DarkCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("dark_crystals");
            entity.Property(e => e.DarkFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("dark_fewell");
            entity.Property(e => e.DarknessSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("darkness_spheres_set");
            entity.Property(e => e.Deeds)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("deeds");
            entity.Property(e => e.DetonationSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("detonation_spheres_set");
            entity.Property(e => e.DistortionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("distortion_spheres_set");
            entity.Property(e => e.DominionNote)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dominion_note");
            entity.Property(e => e.DuskdimStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskdim_stone");
            entity.Property(e => e.DuskdimStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskdim_stone_1");
            entity.Property(e => e.DuskdimStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskdim_stone_2");
            entity.Property(e => e.DuskorbStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskorb_stone");
            entity.Property(e => e.DuskorbStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskorb_stone_1");
            entity.Property(e => e.DuskorbStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskorb_stone_2");
            entity.Property(e => e.DuskslitStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskslit_stone");
            entity.Property(e => e.DuskslitStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskslit_stone_1");
            entity.Property(e => e.DuskslitStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("duskslit_stone_2");
            entity.Property(e => e.DusktipStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dusktip_stone");
            entity.Property(e => e.DusktipStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dusktip_stone_1");
            entity.Property(e => e.DusktipStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dusktip_stone_2");
            entity.Property(e => e.EarthCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("earth_crystal_set");
            entity.Property(e => e.EarthCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("earth_crystals");
            entity.Property(e => e.EarthFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("earth_fewell");
            entity.Property(e => e.EschaBeads)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("escha_beads");
            entity.Property(e => e.EschaSilt)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("escha_silt");
            entity.Property(e => e.FellowPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fellow_point");
            entity.Property(e => e.FernStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fern_stone");
            entity.Property(e => e.FifthEchelonTrophy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fifth_echelon_trophy");
            entity.Property(e => e.FireCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fire_crystal_set");
            entity.Property(e => e.FireCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fire_crystals");
            entity.Property(e => e.FireFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("fire_fewell");
            entity.Property(e => e.FirstEchelonTrophy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("first_echelon_trophy");
            entity.Property(e => e.FourthEchelonTrophy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fourth_echelon_trophy");
            entity.Property(e => e.FragmentationSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fragmentation_spheres_set");
            entity.Property(e => e.FusionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fusion_spheres_set");
            entity.Property(e => e.Gallantry)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("gallantry");
            entity.Property(e => e.GhastlyStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ghastly_stone");
            entity.Property(e => e.GhastlyStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ghastly_stone_1");
            entity.Property(e => e.GhastlyStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ghastly_stone_2");
            entity.Property(e => e.GravitationSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("gravitation_spheres_set");
            entity.Property(e => e.GuildAlchemy)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_alchemy");
            entity.Property(e => e.GuildBonecraft)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_bonecraft");
            entity.Property(e => e.GuildCooking)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_cooking");
            entity.Property(e => e.GuildFishing)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_fishing");
            entity.Property(e => e.GuildGoldsmithing)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_goldsmithing");
            entity.Property(e => e.GuildLeathercraft)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_leathercraft");
            entity.Property(e => e.GuildSmithing)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_smithing");
            entity.Property(e => e.GuildWeaving)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_weaving");
            entity.Property(e => e.GuildWoodworking)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("guild_woodworking");
            entity.Property(e => e.HighKindredCrest)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("high_kindred_crest");
            entity.Property(e => e.IceCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ice_crystal_set");
            entity.Property(e => e.IceCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ice_crystals");
            entity.Property(e => e.IceFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("ice_fewell");
            entity.Property(e => e.IdTags)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("id_tags");
            entity.Property(e => e.IlrusiAssaultPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("ilrusi_assault_point");
            entity.Property(e => e.ImpactionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("impaction_spheres_set");
            entity.Property(e => e.ImperialStanding)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("imperial_standing");
            entity.Property(e => e.Imprimaturs)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("imprimaturs");
            entity.Property(e => e.IndurationSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("induration_spheres_set");
            entity.Property(e => e.Infamy)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("infamy");
            entity.Property(e => e.Jetton)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("jetton");
            entity.Property(e => e.KindredCrest)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("kindred_crest");
            entity.Property(e => e.KindredSeal)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("kindred_seal");
            entity.Property(e => e.KineticUnit)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("kinetic_unit");
            entity.Property(e => e.KupofriedCorundums)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("kupofried_corundums");
            entity.Property(e => e.LeafdimStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leafdim_stone");
            entity.Property(e => e.LeafdimStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leafdim_stone_1");
            entity.Property(e => e.LeafdimStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leafdim_stone_2");
            entity.Property(e => e.LeaforbStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leaforb_stone");
            entity.Property(e => e.LeaforbStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leaforb_stone_1");
            entity.Property(e => e.LeaforbStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leaforb_stone_2");
            entity.Property(e => e.LeafslitStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leafslit_stone");
            entity.Property(e => e.LeafslitStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leafslit_stone_1");
            entity.Property(e => e.LeafslitStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leafslit_stone_2");
            entity.Property(e => e.LeaftipStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leaftip_stone");
            entity.Property(e => e.LeaftipStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leaftip_stone_1");
            entity.Property(e => e.LeaftipStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("leaftip_stone_2");
            entity.Property(e => e.LebondoptWing)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("lebondopt_wing");
            entity.Property(e => e.LebrosAssaultPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("lebros_assault_point");
            entity.Property(e => e.LegionPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("legion_point");
            entity.Property(e => e.LeujaoamAssaultPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("leujaoam_assault_point");
            entity.Property(e => e.LightCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("light_crystal_set");
            entity.Property(e => e.LightCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("light_crystals");
            entity.Property(e => e.LightFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("light_fewell");
            entity.Property(e => e.LightSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("light_spheres_set");
            entity.Property(e => e.LightningCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("lightning_crystal_set");
            entity.Property(e => e.LightningCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("lightning_crystals");
            entity.Property(e => e.LightningFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("lightning_fewell");
            entity.Property(e => e.LiquefactionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("liquefaction_spheres_set");
            entity.Property(e => e.LoginPoints)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("login_points");
            entity.Property(e => e.MamoolAssaultPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mamool_assault_point");
            entity.Property(e => e.McSSr01Set)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("mc_s_sr01_set");
            entity.Property(e => e.McSSr02Set)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("mc_s_sr02_set");
            entity.Property(e => e.McSSr03Set)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("mc_s_sr03_set");
            entity.Property(e => e.MoblinMarble)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("moblin_marble");
            entity.Property(e => e.MorionWorm)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("morion_worm");
            entity.Property(e => e.MweyaPlasm)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mweya_plasm");
            entity.Property(e => e.MysticalCanteen)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("mystical_canteen");
            entity.Property(e => e.NyzulIsleAssaultPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("nyzul_isle_assault_point");
            entity.Property(e => e.ObsidianFragment)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("obsidian_fragment");
            entity.Property(e => e.OpCredits)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("op_credits");
            entity.Property(e => e.PellucidStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pellucid_stone");
            entity.Property(e => e.PeriqiaAssaultPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("periqia_assault_point");
            entity.Property(e => e.PhantomWorm)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("phantom_worm");
            entity.Property(e => e.PheromoneSacks)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pheromone_sacks");
            entity.Property(e => e.Plaudits)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5)")
                .HasColumnName("plaudits");
            entity.Property(e => e.Potpourri)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("potpourri");
            entity.Property(e => e.Prestige)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("prestige");
            entity.Property(e => e.PrevAccolades)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("prev_accolades");
            entity.Property(e => e.PulchridoptWing)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("pulchridopt_wing");
            entity.Property(e => e.ReclamationMarks)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("reclamation_marks");
            entity.Property(e => e.RemsCh1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch1");
            entity.Property(e => e.RemsCh10)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch10");
            entity.Property(e => e.RemsCh2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch2");
            entity.Property(e => e.RemsCh3)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch3");
            entity.Property(e => e.RemsCh4)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch4");
            entity.Property(e => e.RemsCh5)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch5");
            entity.Property(e => e.RemsCh6)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch6");
            entity.Property(e => e.RemsCh7)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch7");
            entity.Property(e => e.RemsCh8)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch8");
            entity.Property(e => e.RemsCh9)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rems_ch9");
            entity.Property(e => e.ResearchMark)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("research_mark");
            entity.Property(e => e.ResistanceCredit)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("resistance_credit");
            entity.Property(e => e.ReverberationSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("reverberation_spheres_set");
            entity.Property(e => e.SacredKindredCrest)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("sacred_kindred_crest");
            entity.Property(e => e.SandoriaCp)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("sandoria_cp");
            entity.Property(e => e.ScissionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("scission_spheres_set");
            entity.Property(e => e.Scyld)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("scyld");
            entity.Property(e => e.SecondEchelonTrophy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("second_echelon_trophy");
            entity.Property(e => e.ShiningStar)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("shining_star");
            entity.Property(e => e.SilverAmanVoucher)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("silver_aman_voucher");
            entity.Property(e => e.SnowdimStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowdim_stone");
            entity.Property(e => e.SnowdimStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowdim_stone_1");
            entity.Property(e => e.SnowdimStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowdim_stone_2");
            entity.Property(e => e.SnoworbStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snoworb_stone");
            entity.Property(e => e.SnoworbStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snoworb_stone_1");
            entity.Property(e => e.SnoworbStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snoworb_stone_2");
            entity.Property(e => e.SnowslitStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowslit_stone");
            entity.Property(e => e.SnowslitStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowslit_stone_1");
            entity.Property(e => e.SnowslitStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowslit_stone_2");
            entity.Property(e => e.SnowtipStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowtip_stone");
            entity.Property(e => e.SnowtipStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowtip_stone_1");
            entity.Property(e => e.SnowtipStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("snowtip_stone_2");
            entity.Property(e => e.SparkOfEminence)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("spark_of_eminence");
            entity.Property(e => e.TaupeStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("taupe_stone");
            entity.Property(e => e.TherionIchor)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("therion_ichor");
            entity.Property(e => e.ThirdEchelonTrophy)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("third_echelon_trophy");
            entity.Property(e => e.TotalHallmarks)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("total_hallmarks");
            entity.Property(e => e.TransfixionSpheresSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("transfixion_spheres_set");
            entity.Property(e => e.TraverserStones)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("traverser_stones");
            entity.Property(e => e.TunnelWorm)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("tunnel_worm");
            entity.Property(e => e.UnityAccolades)
                .HasColumnType("int(5) unsigned")
                .HasColumnName("unity_accolades");
            entity.Property(e => e.ValorPoint)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("valor_point");
            entity.Property(e => e.VerdigrisStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("verdigris_stone");
            entity.Property(e => e.VerdigrisStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("verdigris_stone_1");
            entity.Property(e => e.VerdigrisStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("verdigris_stone_2");
            entity.Property(e => e.Voidstones)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("voidstones");
            entity.Property(e => e.WailingStone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("wailing_stone");
            entity.Property(e => e.WailingStone1)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("wailing_stone_1");
            entity.Property(e => e.WailingStone2)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("wailing_stone_2");
            entity.Property(e => e.WaterCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("water_crystal_set");
            entity.Property(e => e.WaterCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("water_crystals");
            entity.Property(e => e.WaterFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("water_fewell");
            entity.Property(e => e.WindCrystalSet)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("wind_crystal_set");
            entity.Property(e => e.WindCrystals)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("wind_crystals");
            entity.Property(e => e.WindFewell)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wind_fewell");
            entity.Property(e => e.WindurstCp)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("windurst_cp");
            entity.Property(e => e.ZeniPoint)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("zeni_point");
        });

        modelBuilder.Entity<CharProfile>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_profile");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.FameAbyAltepa)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_altepa");
            entity.Property(e => e.FameAbyAttohwa)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_attohwa");
            entity.Property(e => e.FameAbyGrauberg)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_grauberg");
            entity.Property(e => e.FameAbyKonschtat)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_konschtat");
            entity.Property(e => e.FameAbyLatheine)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_latheine");
            entity.Property(e => e.FameAbyMisareaux)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_misareaux");
            entity.Property(e => e.FameAbyTahrongi)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_tahrongi");
            entity.Property(e => e.FameAbyUleguerand)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_uleguerand");
            entity.Property(e => e.FameAbyVunkerl)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_aby_vunkerl");
            entity.Property(e => e.FameAdoulin)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_adoulin");
            entity.Property(e => e.FameBastok)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_bastok");
            entity.Property(e => e.FameJeuno)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_jeuno");
            entity.Property(e => e.FameNorg)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_norg");
            entity.Property(e => e.FameSandoria)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_sandoria");
            entity.Property(e => e.FameWindurst)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fame_windurst");
            entity.Property(e => e.RankBastok)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rank_bastok");
            entity.Property(e => e.RankPoints)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rank_points");
            entity.Property(e => e.RankSandoria)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rank_sandoria");
            entity.Property(e => e.RankWindurst)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rank_windurst");
            entity.Property(e => e.UnityLeader)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("unity_leader");
        });

        modelBuilder.Entity<CharRecast>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("char_recast");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Id)
                .HasColumnType("smallint(5)")
                .HasColumnName("id");
            entity.Property(e => e.Recast)
                .HasColumnType("smallint(5)")
                .HasColumnName("recast");
            entity.Property(e => e.Time)
                .HasColumnType("int(10)")
                .HasColumnName("time");
        });

        modelBuilder.Entity<CharSkill>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Skillid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("char_skills");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Skillid)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("skillid");
            entity.Property(e => e.Rank)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rank");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CharSpell>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("char_spells");

            entity.HasIndex(e => e.Charid, "char_spells_charid_index");

            entity.HasIndex(e => e.Spellid, "char_spells_spellid_index");

            entity.HasIndex(e => new { e.Spellid, e.Charid }, "idx_char_spells_spellid_charid").IsUnique();

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Spellid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("spellid");
        });

        modelBuilder.Entity<CharStat>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_stats");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.BazaarMessage)
                .HasColumnType("blob")
                .HasColumnName("bazaar_message");
            entity.Property(e => e.Death)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("death");
            entity.Property(e => e.Hp)
                .HasDefaultValueSql("'50'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("hp");
            entity.Property(e => e.Mhflag)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mhflag");
            entity.Property(e => e.Mjob)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mjob");
            entity.Property(e => e.Mlvl)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mlvl");
            entity.Property(e => e.Mp)
                .HasDefaultValueSql("'50'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mp");
            entity.Property(e => e.PetHp)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_hp");
            entity.Property(e => e.PetId)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("pet_id");
            entity.Property(e => e.PetLevel)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("pet_level");
            entity.Property(e => e.PetMp)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_mp");
            entity.Property(e => e.PetType)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("pet_type");
            entity.Property(e => e.Sjob)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sjob");
            entity.Property(e => e.Slvl)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("slvl");
            entity.Property(e => e.Title)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("title");
            entity.Property(e => e.Zoning)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("zoning");
            entity.Property(e => e._2h)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("2h");
        });

        modelBuilder.Entity<CharStorage>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_storage");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Case)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("case");
            entity.Property(e => e.Inventory)
                .HasDefaultValueSql("'30'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("inventory");
            entity.Property(e => e.Locker)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("locker");
            entity.Property(e => e.Sack)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sack");
            entity.Property(e => e.Safe)
                .HasDefaultValueSql("'50'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("safe");
            entity.Property(e => e.Satchel)
                .HasDefaultValueSql("'30'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("satchel");
            entity.Property(e => e.Wardrobe)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe");
            entity.Property(e => e.Wardrobe2)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe2");
            entity.Property(e => e.Wardrobe3)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe3");
            entity.Property(e => e.Wardrobe4)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe4");
            entity.Property(e => e.Wardrobe5)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe5");
            entity.Property(e => e.Wardrobe6)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe6");
            entity.Property(e => e.Wardrobe7)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe7");
            entity.Property(e => e.Wardrobe8)
                .HasDefaultValueSql("'80'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("wardrobe8");
        });

        modelBuilder.Entity<CharStyle>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_style");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Body)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("body");
            entity.Property(e => e.Feet)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("feet");
            entity.Property(e => e.Hands)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("hands");
            entity.Property(e => e.Head)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("head");
            entity.Property(e => e.Legs)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("legs");
            entity.Property(e => e.Main)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("main");
            entity.Property(e => e.Ranged)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ranged");
            entity.Property(e => e.Sub)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("sub");
        });

        modelBuilder.Entity<CharUnlock>(entity =>
        {
            entity.HasKey(e => e.Charid).HasName("PRIMARY");

            entity.ToTable("char_unlocks");

            entity.Property(e => e.Charid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.AbysseaConflux)
                .HasColumnType("blob")
                .HasColumnName("abyssea_conflux");
            entity.Property(e => e.CampaignBastok)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_bastok");
            entity.Property(e => e.CampaignSandy)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_sandy");
            entity.Property(e => e.CampaignWindy)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("campaign_windy");
            entity.Property(e => e.ClaimedDeeds)
                .HasColumnType("blob")
                .HasColumnName("claimed_deeds");
            entity.Property(e => e.EschanPortals)
                .HasColumnType("blob")
                .HasColumnName("eschan_portals");
            entity.Property(e => e.Homepoints)
                .HasColumnType("blob")
                .HasColumnName("homepoints");
            entity.Property(e => e.Maw)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("maw");
            entity.Property(e => e.MogLocker)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mog_locker");
            entity.Property(e => e.OutpostBastok)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("outpost_bastok");
            entity.Property(e => e.OutpostSandy)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("outpost_sandy");
            entity.Property(e => e.OutpostWindy)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("outpost_windy");
            entity.Property(e => e.RunicPortal)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("runic_portal");
            entity.Property(e => e.Survivals)
                .HasColumnType("blob")
                .HasColumnName("survivals");
            entity.Property(e => e.TraverserClaimed)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("traverser_claimed");
            entity.Property(e => e.TraverserStart)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("traverser_start");
            entity.Property(e => e.UniqueEvent)
                .HasColumnType("blob")
                .HasColumnName("unique_event");
            entity.Property(e => e.Waypoints)
                .HasColumnType("blob")
                .HasColumnName("waypoints");
        });

        modelBuilder.Entity<CharVar>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Varname })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("char_vars");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Varname)
                .HasMaxLength(30)
                .HasColumnName("varname");
            entity.Property(e => e.Expiry)
                .HasColumnType("int(11)")
                .HasColumnName("expiry");
            entity.Property(e => e.Value)
                .HasColumnType("int(11)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CheatIncident>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cheat_incidents");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Cheatarg)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cheatarg");
            entity.Property(e => e.Cheatid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cheatid");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description")
                .UseCollation("utf8_unicode_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.IncidentTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("incident_time");
        });

        modelBuilder.Entity<CheatType>(entity =>
        {
            entity.HasKey(e => e.Cheatid).HasName("PRIMARY");

            entity.ToTable("cheat_types");

            entity.Property(e => e.Cheatid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("cheatid");
            entity.Property(e => e.ActionBitmask)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("action_bitmask");
            entity.Property(e => e.Argument)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("argument");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .HasColumnName("name");
            entity.Property(e => e.WarningMessage)
                .HasMaxLength(128)
                .HasColumnName("warning_message");
        });

        modelBuilder.Entity<ConquestSystem>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PRIMARY");

            entity.ToTable("conquest_system");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnType("tinyint(2)")
                .HasColumnName("region_id");
            entity.Property(e => e.BastokInfluence)
                .HasColumnType("int(10)")
                .HasColumnName("bastok_influence");
            entity.Property(e => e.BeastmenInfluence)
                .HasColumnType("int(10)")
                .HasColumnName("beastmen_influence");
            entity.Property(e => e.RegionControl)
                .HasColumnType("tinyint(2)")
                .HasColumnName("region_control");
            entity.Property(e => e.RegionControlPrev)
                .HasColumnType("tinyint(2)")
                .HasColumnName("region_control_prev");
            entity.Property(e => e.SandoriaInfluence)
                .HasColumnType("int(10)")
                .HasColumnName("sandoria_influence");
            entity.Property(e => e.WindurstInfluence)
                .HasColumnType("int(10)")
                .HasColumnName("windurst_influence");
        });

        modelBuilder.Entity<DeliveryBox>(entity =>
        {
            entity.HasKey(e => new { e.Charid, e.Box, e.Slot })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("delivery_box");

            entity.Property(e => e.Charid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("charid");
            entity.Property(e => e.Box)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("box");
            entity.Property(e => e.Slot)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("slot");
            entity.Property(e => e.Charname)
                .HasMaxLength(15)
                .HasColumnName("charname");
            entity.Property(e => e.Extra)
                .HasColumnType("tinyblob")
                .HasColumnName("extra");
            entity.Property(e => e.Itemid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Itemsubid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemsubid");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("quantity");
            entity.Property(e => e.Received).HasColumnName("received");
            entity.Property(e => e.Sender)
                .HasMaxLength(15)
                .HasColumnName("sender");
            entity.Property(e => e.Senderid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("senderid");
            entity.Property(e => e.Sent).HasColumnName("sent");
        });

        modelBuilder.Entity<DespoilEffect>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PRIMARY");

            entity.ToTable("despoil_effects");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.EffectId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("effectId");
        });

        modelBuilder.Entity<ExpBase>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("exp_base");

            entity.Property(e => e.Level)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.Exp)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("exp");
        });

        modelBuilder.Entity<ExpTable>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("exp_table");

            entity.Property(e => e.Level)
                .ValueGeneratedNever()
                .HasColumnType("tinyint(2)")
                .HasColumnName("level");
            entity.Property(e => e.R1)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r1");
            entity.Property(e => e.R10)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r10");
            entity.Property(e => e.R11)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r11");
            entity.Property(e => e.R12)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r12");
            entity.Property(e => e.R13)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r13");
            entity.Property(e => e.R14)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r14");
            entity.Property(e => e.R15)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r15");
            entity.Property(e => e.R16)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r16");
            entity.Property(e => e.R17)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r17");
            entity.Property(e => e.R18)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r18");
            entity.Property(e => e.R19)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r19");
            entity.Property(e => e.R2)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r2");
            entity.Property(e => e.R20)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r20");
            entity.Property(e => e.R3)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r3");
            entity.Property(e => e.R4)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r4");
            entity.Property(e => e.R5)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r5");
            entity.Property(e => e.R6)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r6");
            entity.Property(e => e.R7)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r7");
            entity.Property(e => e.R8)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r8");
            entity.Property(e => e.R9)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("r9");
        });

        modelBuilder.Entity<FishingArea>(entity =>
        {
            entity.HasKey(e => new { e.Zoneid, e.Areaid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("fishing_area");

            entity.Property(e => e.Zoneid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zoneid");
            entity.Property(e => e.Areaid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("areaid");
            entity.Property(e => e.BoundHeight)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("bound_height");
            entity.Property(e => e.BoundRadius)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("bound_radius");
            entity.Property(e => e.BoundType)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("bound_type");
            entity.Property(e => e.Bounds)
                .HasColumnType("blob")
                .HasColumnName("bounds");
            entity.Property(e => e.CenterX)
                .HasColumnType("float(7,3)")
                .HasColumnName("center_x");
            entity.Property(e => e.CenterY)
                .HasColumnType("float(7,3)")
                .HasColumnName("center_y");
            entity.Property(e => e.CenterZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("center_z");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<FishingBait>(entity =>
        {
            entity.HasKey(e => e.Baitid).HasName("PRIMARY");

            entity.ToTable("fishing_bait");

            entity.Property(e => e.Baitid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("baitid");
            entity.Property(e => e.Flags)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.Losable)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("losable");
            entity.Property(e => e.Maxhook)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("maxhook");
            entity.Property(e => e.Mmm)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mmm");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Rankmod)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rankmod");
            entity.Property(e => e.Type)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("type");
        });

        modelBuilder.Entity<FishingBaitAffinity>(entity =>
        {
            entity.HasKey(e => new { e.Baitid, e.Fishid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("fishing_bait_affinity");

            entity.Property(e => e.Baitid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("baitid");
            entity.Property(e => e.Fishid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("fishid");
            entity.Property(e => e.Power)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("power");
        });

        modelBuilder.Entity<FishingCatch>(entity =>
        {
            entity.HasKey(e => new { e.Zoneid, e.Areaid, e.Groupid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("fishing_catch");

            entity.Property(e => e.Zoneid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zoneid");
            entity.Property(e => e.Areaid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("areaid");
            entity.Property(e => e.Groupid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("groupid");
        });

        modelBuilder.Entity<FishingFish>(entity =>
        {
            entity.HasKey(e => e.Fishid).HasName("PRIMARY");

            entity.ToTable("fishing_fish");

            entity.Property(e => e.Fishid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fishid");
            entity.Property(e => e.BaseDelay)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("base_delay");
            entity.Property(e => e.BaseMove)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("base_move");
            entity.Property(e => e.Contest)
                .HasColumnType("tinyint(2)")
                .HasColumnName("contest");
            entity.Property(e => e.Difficulty)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("difficulty");
            entity.Property(e => e.Disabled)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("disabled");
            entity.Property(e => e.Family)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("family");
            entity.Property(e => e.Flags)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.HourPattern)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("hour_pattern");
            entity.Property(e => e.Item)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("item");
            entity.Property(e => e.Legendary)
                .HasColumnType("int(2) unsigned")
                .HasColumnName("legendary");
            entity.Property(e => e.LegendaryFlags)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("legendary_flags");
            entity.Property(e => e.Log)
                .HasDefaultValueSql("'255'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("log");
            entity.Property(e => e.MaxHook)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("max_hook");
            entity.Property(e => e.MaxLength)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.MinLength)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_length");
            entity.Property(e => e.MonthPattern)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("month_pattern");
            entity.Property(e => e.MoonPattern)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("moon_pattern");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'255'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.QuestOnly)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("quest_only");
            entity.Property(e => e.QuestStatus)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("quest_status");
            entity.Property(e => e.Ranking)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ranking");
            entity.Property(e => e.Rarity)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rarity");
            entity.Property(e => e.RequiredCatches)
                .HasColumnType("blob")
                .HasColumnName("required_catches");
            entity.Property(e => e.RequiredKeyitem)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("required_keyitem");
            entity.Property(e => e.SizeType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("size_type");
            entity.Property(e => e.SkillLevel)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("skill_level");
            entity.Property(e => e.WaterType)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("water_type");
        });

        modelBuilder.Entity<FishingGroup>(entity =>
        {
            entity.HasKey(e => new { e.Groupid, e.Fishid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("fishing_group");

            entity.Property(e => e.Groupid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("groupid");
            entity.Property(e => e.Fishid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("fishid");
            entity.Property(e => e.PoolSize)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("pool_size");
            entity.Property(e => e.Rarity)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rarity");
            entity.Property(e => e.RestockRate)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("restock_rate");
        });

        modelBuilder.Entity<FishingMob>(entity =>
        {
            entity.HasKey(e => e.Mobid).HasName("PRIMARY");

            entity.ToTable("fishing_mob");

            entity.Property(e => e.Mobid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mobid");
            entity.Property(e => e.AlternativeBaitid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("alternative_baitid");
            entity.Property(e => e.Areaid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("areaid");
            entity.Property(e => e.BaseDelay)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("base_delay");
            entity.Property(e => e.BaseMove)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("base_move");
            entity.Property(e => e.Difficulty)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("difficulty");
            entity.Property(e => e.Disabled)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("disabled");
            entity.Property(e => e.Level)
                .HasColumnType("tinyint(3)")
                .HasColumnName("level");
            entity.Property(e => e.Log)
                .HasDefaultValueSql("'255'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("log");
            entity.Property(e => e.MaxLength)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("max_length");
            entity.Property(e => e.MaxRespawn)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_respawn");
            entity.Property(e => e.MinLength)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_length");
            entity.Property(e => e.MinRespawn)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("min_respawn");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Nm)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("nm");
            entity.Property(e => e.NmFlags)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("nm_flags");
            entity.Property(e => e.Quest)
                .HasDefaultValueSql("'255'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("quest");
            entity.Property(e => e.QuestOnly)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("quest_only");
            entity.Property(e => e.Ranking)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ranking");
            entity.Property(e => e.Rarity)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rarity");
            entity.Property(e => e.RequiredBaitid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("required_baitid");
            entity.Property(e => e.RequiredKeyitem)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("required_keyitem");
            entity.Property(e => e.Zoneid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zoneid");
        });

        modelBuilder.Entity<FishingRod>(entity =>
        {
            entity.HasKey(e => e.Rodid).HasName("PRIMARY");

            entity.ToTable("fishing_rod");

            entity.Property(e => e.Rodid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("rodid");
            entity.Property(e => e.Breakable)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("breakable");
            entity.Property(e => e.BrokenRodid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("broken_rodid");
            entity.Property(e => e.FishAttack)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fish_attack");
            entity.Property(e => e.FishRecovery)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fish_recovery");
            entity.Property(e => e.FishTime)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("fish_time");
            entity.Property(e => e.Flags)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.Legendary)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("legendary");
            entity.Property(e => e.LgDelayBonus)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("lg_delay_bonus");
            entity.Property(e => e.LgMoveBonus)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("lg_move_bonus");
            entity.Property(e => e.LgdBonusAttack)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("lgd_bonus_attack");
            entity.Property(e => e.LgdBonusTime)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("lgd_bonus_time");
            entity.Property(e => e.Material)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("material");
            entity.Property(e => e.MaxRank)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("max_rank");
            entity.Property(e => e.MinRank)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_rank");
            entity.Property(e => e.Mmm)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mmm");
            entity.Property(e => e.Multiplier)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("multiplier");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Rating)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rating");
            entity.Property(e => e.SizeType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("size_type");
            entity.Property(e => e.SmDelayBonus)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sm_delay_bonus");
            entity.Property(e => e.SmMoveBonus)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sm_move_bonus");
        });

        modelBuilder.Entity<FishingZone>(entity =>
        {
            entity.HasKey(e => e.Zoneid).HasName("PRIMARY");

            entity.ToTable("fishing_zone");

            entity.Property(e => e.Zoneid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zoneid");
            entity.Property(e => e.Difficulty)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("difficulty");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GardeningResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PRIMARY");

            entity.ToTable("gardening_results");

            entity.Property(e => e.ResultId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("resultId");
            entity.Property(e => e.Element1)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("element1");
            entity.Property(e => e.Element2)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("element2");
            entity.Property(e => e.MaxQuantity)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("max_quantity");
            entity.Property(e => e.MinQuantity)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("min_quantity");
            entity.Property(e => e.Result)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("result");
            entity.Property(e => e.Seed)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("seed");
            entity.Property(e => e.Weight)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<Guild>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("guilds");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.PointsName)
                .HasMaxLength(20)
                .HasColumnName("points_name");
        });

        modelBuilder.Entity<GuildItemPoint>(entity =>
        {
            entity.HasKey(e => new { e.Guildid, e.Itemid, e.Pattern })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("guild_item_points");

            entity.Property(e => e.Guildid)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("guildid");
            entity.Property(e => e.Itemid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Pattern)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("pattern");
            entity.Property(e => e.MaxPoints)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("max_points");
            entity.Property(e => e.Points)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("points");
            entity.Property(e => e.Rank)
                .HasColumnType("smallint(1) unsigned")
                .HasColumnName("rank");
        });

        modelBuilder.Entity<GuildShop>(entity =>
        {
            entity.HasKey(e => new { e.Guildid, e.Itemid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("guild_shops");

            entity.Property(e => e.Guildid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("guildid");
            entity.Property(e => e.Itemid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.DailyIncrease)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("daily_increase");
            entity.Property(e => e.InitialQuantity)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("initial_quantity");
            entity.Property(e => e.MaxPrice)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("max_price");
            entity.Property(e => e.MaxQuantity)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("max_quantity");
            entity.Property(e => e.MinPrice)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("min_price");
        });

        modelBuilder.Entity<InstanceEntity>(entity =>
        {
            entity.HasKey(e => new { e.Instanceid, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("instance_entities");

            entity.Property(e => e.Instanceid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("instanceid");
            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
        });

        modelBuilder.Entity<InstanceList>(entity =>
        {
            entity.HasKey(e => e.Instanceid).HasName("PRIMARY");

            entity.ToTable("instance_list");

            entity.Property(e => e.Instanceid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("instanceid");
            entity.Property(e => e.Battlemulti)
                .HasDefaultValueSql("-1")
                .HasColumnType("smallint(3)")
                .HasColumnName("battlemulti");
            entity.Property(e => e.Battlesolo)
                .HasDefaultValueSql("-1")
                .HasColumnType("smallint(3)")
                .HasColumnName("battlesolo");
            entity.Property(e => e.EntranceZone)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("entrance_zone");
            entity.Property(e => e.InstanceName)
                .HasMaxLength(35)
                .HasDefaultValueSql("''")
                .HasColumnName("instance_name");
            entity.Property(e => e.InstanceZone)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("instance_zone");
            entity.Property(e => e.MusicDay)
                .HasDefaultValueSql("-1")
                .HasColumnType("smallint(3)")
                .HasColumnName("music_day");
            entity.Property(e => e.MusicNight)
                .HasDefaultValueSql("-1")
                .HasColumnType("smallint(3)")
                .HasColumnName("music_night");
            entity.Property(e => e.StartRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("start_rot");
            entity.Property(e => e.StartX)
                .HasColumnType("float(7,3)")
                .HasColumnName("start_x");
            entity.Property(e => e.StartY)
                .HasColumnType("float(7,3)")
                .HasColumnName("start_y");
            entity.Property(e => e.StartZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("start_z");
            entity.Property(e => e.TimeLimit)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("time_limit");
        });

        modelBuilder.Entity<IpException>(entity =>
        {
            entity.HasKey(e => e.Accid).HasName("PRIMARY");

            entity.ToTable("ip_exceptions");

            entity.Property(e => e.Accid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("accid");
            entity.Property(e => e.Comment)
                .HasMaxLength(512)
                .HasColumnName("comment");
            entity.Property(e => e.Exception)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("exception");
        });

        modelBuilder.Entity<ItemBasic>(entity =>
        {
            entity.HasKey(e => e.Itemid).HasName("PRIMARY");

            entity.ToTable("item_basic");

            entity.Property(e => e.Itemid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.AH)
                .HasDefaultValueSql("'99'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("aH");
            entity.Property(e => e.BaseSell).HasColumnType("int(10) unsigned");
            entity.Property(e => e.Flags)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.NoSale).HasColumnType("tinyint(1) unsigned");
            entity.Property(e => e.Sortname)
                .HasColumnType("tinytext")
                .HasColumnName("sortname");
            entity.Property(e => e.StackSize)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("stackSize");
            entity.Property(e => e.Subid)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("subid");
        });

        modelBuilder.Entity<ItemEquipment>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PRIMARY");

            entity.ToTable("item_equipment");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.Ilevel)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ilevel");
            entity.Property(e => e.Jobs)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("jobs");
            entity.Property(e => e.Level)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.Mid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("MId");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.Rslot)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("rslot");
            entity.Property(e => e.ScriptType)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("scriptType");
            entity.Property(e => e.ShieldSize)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("shieldSize");
            entity.Property(e => e.Slot)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("slot");
            entity.Property(e => e.SuLevel)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("su_level");
        });

        modelBuilder.Entity<ItemFurnishing>(entity =>
        {
            entity.HasKey(e => e.Itemid).HasName("PRIMARY");

            entity.ToTable("item_furnishing");

            entity.Property(e => e.Itemid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Aura)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("aura");
            entity.Property(e => e.Element)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("element");
            entity.Property(e => e.Moghancement)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("moghancement");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Storage)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("storage");
        });

        modelBuilder.Entity<ItemLatent>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.ModId, e.Value, e.LatentId, e.LatentParam })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("item_latents");

            entity.Property(e => e.ItemId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.ModId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modId");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
            entity.Property(e => e.LatentId)
                .HasColumnType("smallint(5)")
                .HasColumnName("latentId");
            entity.Property(e => e.LatentParam)
                .HasColumnType("smallint(5)")
                .HasColumnName("latentParam");
        });

        modelBuilder.Entity<ItemMod>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.ModId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("item_mods");

            entity.Property(e => e.ItemId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.ModId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modId");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<ItemModsPet>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.ModId, e.PetType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("item_mods_pet");

            entity.Property(e => e.ItemId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.ModId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modId");
            entity.Property(e => e.PetType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("petType");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<ItemPuppet>(entity =>
        {
            entity.HasKey(e => e.Itemid).HasName("PRIMARY");

            entity.ToTable("item_puppet");

            entity.Property(e => e.Itemid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Element)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("element");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.Slot)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("slot");
        });

        modelBuilder.Entity<ItemUsable>(entity =>
        {
            entity.HasKey(e => e.Itemid).HasName("PRIMARY");

            entity.ToTable("item_usable");

            entity.Property(e => e.Itemid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemid");
            entity.Property(e => e.Activation)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("activation");
            entity.Property(e => e.Animation)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("animation");
            entity.Property(e => e.AnimationTime)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("animationTime");
            entity.Property(e => e.Aoe)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("aoe");
            entity.Property(e => e.MaxCharges)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("maxCharges");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.ReuseDelay)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("reuseDelay");
            entity.Property(e => e.UseDelay)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("useDelay");
            entity.Property(e => e.ValidTargets)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("validTargets");
        });

        modelBuilder.Entity<ItemWeapon>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PRIMARY");

            entity.ToTable("item_weapon");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.Delay)
                .HasColumnType("int(10)")
                .HasColumnName("delay");
            entity.Property(e => e.Dmg)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dmg");
            entity.Property(e => e.DmgType)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dmgType");
            entity.Property(e => e.Hit)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("hit");
            entity.Property(e => e.IlvlMacc)
                .HasColumnType("smallint(3)")
                .HasColumnName("ilvl_macc");
            entity.Property(e => e.IlvlParry)
                .HasColumnType("smallint(3)")
                .HasColumnName("ilvl_parry");
            entity.Property(e => e.IlvlSkill)
                .HasColumnType("smallint(3)")
                .HasColumnName("ilvl_skill");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Skill)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("skill");
            entity.Property(e => e.Subskill)
                .HasColumnType("tinyint(2)")
                .HasColumnName("subskill");
            entity.Property(e => e.UnlockPoints)
                .HasColumnType("smallint(5)")
                .HasColumnName("unlock_points");
        });

        modelBuilder.Entity<JobPoint>(entity =>
        {
            entity.HasKey(e => e.JobPointid).HasName("PRIMARY");

            entity.ToTable("job_points");

            entity.Property(e => e.JobPointid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(10) unsigned")
                .HasColumnName("job_pointid");
            entity.Property(e => e.Jobs)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("jobs");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Upgrade)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("upgrade");
        });

        modelBuilder.Entity<JobPointGift>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("job_point_gifts");

            entity.Property(e => e.Desc)
                .HasDefaultValueSql("''")
                .HasColumnType("tinytext")
                .HasColumnName("desc");
            entity.Property(e => e.Jobid)
                .HasColumnType("tinyint(4)")
                .HasColumnName("jobid");
            entity.Property(e => e.JpNeeded)
                .HasColumnType("smallint(6)")
                .HasColumnName("jp_needed");
            entity.Property(e => e.Modid)
                .HasColumnType("smallint(6)")
                .HasColumnName("modid");
            entity.Property(e => e.Value)
                .HasColumnType("tinyint(4)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Linkshell>(entity =>
        {
            entity.HasKey(e => e.Linkshellid).HasName("PRIMARY");

            entity.ToTable("linkshells");

            entity.Property(e => e.Linkshellid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("linkshellid");
            entity.Property(e => e.Broken)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("broken");
            entity.Property(e => e.Color)
                .HasDefaultValueSql("'61440'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("color");
            entity.Property(e => e.Message)
                .HasColumnType("blob")
                .HasColumnName("message");
            entity.Property(e => e.Messagetime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("messagetime");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Poster)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("poster");
            entity.Property(e => e.Postrights)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("postrights");
        });

        modelBuilder.Entity<Merit>(entity =>
        {
            entity.HasKey(e => e.Meritid).HasName("PRIMARY");

            entity.ToTable("merits");

            entity.Property(e => e.Meritid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("meritid");
            entity.Property(e => e.Catagoryid)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("catagoryid");
            entity.Property(e => e.Jobs)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("jobs");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Upgrade)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("upgrade");
            entity.Property(e => e.Upgradeid)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("upgradeid");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MobDroplist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mob_droplist");

            entity.HasIndex(e => e.DropId, "dropId");

            entity.Property(e => e.DropId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("dropId");
            entity.Property(e => e.DropType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dropType");
            entity.Property(e => e.GroupId)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("groupId");
            entity.Property(e => e.GroupRate)
                .HasDefaultValueSql("'1000'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("groupRate");
            entity.Property(e => e.ItemId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("itemId");
            entity.Property(e => e.ItemRate)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("itemRate");
        });

        modelBuilder.Entity<MobFamilyMod>(entity =>
        {
            entity.HasKey(e => new { e.Familyid, e.Modid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("mob_family_mods");

            entity.Property(e => e.Familyid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("familyid");
            entity.Property(e => e.Modid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modid");
            entity.Property(e => e.IsMobMod).HasColumnName("is_mob_mod");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MobFamilySystem>(entity =>
        {
            entity.HasKey(e => e.FamilyId).HasName("PRIMARY");

            entity.ToTable("mob_family_system");

            entity.Property(e => e.FamilyId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("familyID");
            entity.Property(e => e.Acc)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("ACC");
            entity.Property(e => e.Agi)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("AGI");
            entity.Property(e => e.Att)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("ATT");
            entity.Property(e => e.Charmable)
                .HasColumnType("tinyint(2)")
                .HasColumnName("charmable");
            entity.Property(e => e.Chr)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("CHR");
            entity.Property(e => e.Def)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("DEF");
            entity.Property(e => e.Detects)
                .HasColumnType("smallint(5)")
                .HasColumnName("detects");
            entity.Property(e => e.Dex)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("DEX");
            entity.Property(e => e.Ecosystem)
                .HasColumnType("tinytext")
                .HasColumnName("ecosystem");
            entity.Property(e => e.EcosystemId)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("ecosystemID");
            entity.Property(e => e.Eva)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("EVA");
            entity.Property(e => e.Family)
                .HasColumnType("tinytext")
                .HasColumnName("family");
            entity.Property(e => e.Hp)
                .HasDefaultValueSql("'100'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("HP");
            entity.Property(e => e.Int)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("INT");
            entity.Property(e => e.Mnd)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("MND");
            entity.Property(e => e.Mobradius)
                .HasDefaultValueSql("'0.01'")
                .HasColumnType("float(5,2) unsigned")
                .HasColumnName("mobradius");
            entity.Property(e => e.Mp)
                .HasDefaultValueSql("'100'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("MP");
            entity.Property(e => e.Speed)
                .HasDefaultValueSql("'40'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("speed");
            entity.Property(e => e.Str)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("STR");
            entity.Property(e => e.SuperFamily)
                .HasColumnType("tinytext")
                .HasColumnName("superFamily");
            entity.Property(e => e.SuperFamilyId)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("superFamilyID");
            entity.Property(e => e.Vit)
                .HasDefaultValueSql("'3'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("VIT");
        });

        modelBuilder.Entity<MobGroup>(entity =>
        {
            entity.HasKey(e => new { e.Zoneid, e.Groupid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("mob_groups");

            entity.Property(e => e.Zoneid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("zoneid");
            entity.Property(e => e.Groupid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("groupid");
            entity.Property(e => e.Allegiance)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("allegiance");
            entity.Property(e => e.Dropid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("dropid");
            entity.Property(e => e.Hp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(8)")
                .HasColumnName("HP");
            entity.Property(e => e.MaxLevel)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("maxLevel");
            entity.Property(e => e.MinLevel)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("minLevel");
            entity.Property(e => e.Mp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(8)")
                .HasColumnName("MP");
            entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasColumnName("name");
            entity.Property(e => e.Poolid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poolid");
            entity.Property(e => e.Respawntime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("respawntime");
            entity.Property(e => e.Spawntype)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("spawntype");
        });

        modelBuilder.Entity<MobPet>(entity =>
        {
            entity.HasKey(e => e.MobMobid).HasName("PRIMARY");

            entity.ToTable("mob_pets");

            entity.Property(e => e.MobMobid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mob_mobid");
            entity.Property(e => e.Job)
                .HasDefaultValueSql("'9'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("job");
            entity.Property(e => e.Mobname)
                .HasMaxLength(24)
                .HasColumnName("mobname");
            entity.Property(e => e.PetOffset)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(10) unsigned")
                .HasColumnName("pet_offset");
            entity.Property(e => e.Petname)
                .HasMaxLength(24)
                .HasColumnName("petname");
        });

        modelBuilder.Entity<MobPool>(entity =>
        {
            entity.HasKey(e => e.Poolid).HasName("PRIMARY");

            entity.ToTable("mob_pools");

            entity.Property(e => e.Poolid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poolid");
            entity.Property(e => e.Aggro)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("aggro");
            entity.Property(e => e.Animationsub).HasColumnName("animationsub");
            entity.Property(e => e.Behavior)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("behavior");
            entity.Property(e => e.CmbDelay)
                .HasDefaultValueSql("'240'")
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("cmbDelay");
            entity.Property(e => e.CmbDmgMult)
                .HasDefaultValueSql("'100'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("cmbDmgMult");
            entity.Property(e => e.CmbSkill)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("cmbSkill");
            entity.Property(e => e.EntityFlags)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("entityFlags");
            entity.Property(e => e.Familyid)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("familyid");
            entity.Property(e => e.Flag)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("flag");
            entity.Property(e => e.HasSpellScript)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("hasSpellScript");
            entity.Property(e => e.Immunity)
                .HasColumnType("int(10)")
                .HasColumnName("immunity");
            entity.Property(e => e.Links)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("links");
            entity.Property(e => e.MJob)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mJob");
            entity.Property(e => e.MobType)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("mobType");
            entity.Property(e => e.Modelid)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("modelid");
            entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasColumnName("name");
            entity.Property(e => e.NamePrefix)
                .HasColumnType("tinyint(4) unsigned")
                .HasColumnName("name_prefix");
            entity.Property(e => e.Namevis)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(4)")
                .HasColumnName("namevis");
            entity.Property(e => e.PacketName)
                .HasMaxLength(24)
                .HasColumnName("packet_name");
            entity.Property(e => e.ResistId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("resist_id");
            entity.Property(e => e.Roamflag)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("roamflag");
            entity.Property(e => e.SJob)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sJob");
            entity.Property(e => e.SkillListId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("skill_list_id");
            entity.Property(e => e.SpellList)
                .HasColumnType("smallint(4)")
                .HasColumnName("spellList");
            entity.Property(e => e.TrueDetection)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("true_detection");
        });

        modelBuilder.Entity<MobPoolMod>(entity =>
        {
            entity.HasKey(e => new { e.Poolid, e.Modid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("mob_pool_mods");

            entity.Property(e => e.Poolid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("poolid");
            entity.Property(e => e.Modid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modid");
            entity.Property(e => e.IsMobMod).HasColumnName("is_mob_mod");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MobResistance>(entity =>
        {
            entity.HasKey(e => e.ResistId).HasName("PRIMARY");

            entity.ToTable("mob_resistances");

            entity.Property(e => e.ResistId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("resist_id");
            entity.Property(e => e.DarkResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("dark_res_rank");
            entity.Property(e => e.DarkSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("dark_sdt");
            entity.Property(e => e.EarthResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("earth_res_rank");
            entity.Property(e => e.EarthSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("earth_sdt");
            entity.Property(e => e.FireResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("fire_res_rank");
            entity.Property(e => e.FireSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("fire_sdt");
            entity.Property(e => e.H2hSdt)
                .HasDefaultValueSql("'1'")
                .HasColumnName("h2h_sdt");
            entity.Property(e => e.IceResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("ice_res_rank");
            entity.Property(e => e.IceSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("ice_sdt");
            entity.Property(e => e.ImpactSdt)
                .HasDefaultValueSql("'1'")
                .HasColumnName("impact_sdt");
            entity.Property(e => e.LightResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("light_res_rank");
            entity.Property(e => e.LightSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("light_sdt");
            entity.Property(e => e.LightningResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("lightning_res_rank");
            entity.Property(e => e.LightningSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("lightning_sdt");
            entity.Property(e => e.MagicalSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("magical_sdt");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.PierceSdt)
                .HasDefaultValueSql("'1'")
                .HasColumnName("pierce_sdt");
            entity.Property(e => e.SlashSdt)
                .HasDefaultValueSql("'1'")
                .HasColumnName("slash_sdt");
            entity.Property(e => e.WaterResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("water_res_rank");
            entity.Property(e => e.WaterSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("water_sdt");
            entity.Property(e => e.WindResRank)
                .HasColumnType("smallint(3)")
                .HasColumnName("wind_res_rank");
            entity.Property(e => e.WindSdt)
                .HasColumnType("smallint(5)")
                .HasColumnName("wind_sdt");
        });

        modelBuilder.Entity<MobSkill>(entity =>
        {
            entity.HasKey(e => e.MobSkillId).HasName("PRIMARY");

            entity.ToTable("mob_skills");

            entity.Property(e => e.MobSkillId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mob_skill_id");
            entity.Property(e => e.Knockback).HasColumnName("knockback");
            entity.Property(e => e.MobAnimId)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mob_anim_id");
            entity.Property(e => e.MobAnimTime)
                .HasDefaultValueSql("'2000'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mob_anim_time");
            entity.Property(e => e.MobPrepareTime)
                .HasDefaultValueSql("'1000'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mob_prepare_time");
            entity.Property(e => e.MobSkillAoe)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("mob_skill_aoe");
            entity.Property(e => e.MobSkillDistance)
                .HasDefaultValueSql("'6.0'")
                .HasColumnType("float(3,1)")
                .HasColumnName("mob_skill_distance");
            entity.Property(e => e.MobSkillFlag)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("mob_skill_flag");
            entity.Property(e => e.MobSkillName)
                .HasMaxLength(40)
                .HasColumnName("mob_skill_name")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.MobSkillParam)
                .HasColumnType("smallint(5)")
                .HasColumnName("mob_skill_param");
            entity.Property(e => e.MobValidTargets)
                .HasDefaultValueSql("'4'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mob_valid_targets");
            entity.Property(e => e.PrimarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("primary_sc");
            entity.Property(e => e.SecondarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("secondary_sc");
            entity.Property(e => e.TertiarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("tertiary_sc");
        });

        modelBuilder.Entity<MobSkillList>(entity =>
        {
            entity.HasKey(e => new { e.SkillListId, e.MobSkillId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("mob_skill_lists");

            entity.Property(e => e.SkillListId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("skill_list_id");
            entity.Property(e => e.MobSkillId)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("mob_skill_id");
            entity.Property(e => e.SkillListName)
                .HasMaxLength(40)
                .HasColumnName("skill_list_name");
        });

        modelBuilder.Entity<MobSpawnMod>(entity =>
        {
            entity.HasKey(e => new { e.Mobid, e.Modid })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("mob_spawn_mods");

            entity.Property(e => e.Mobid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("mobid");
            entity.Property(e => e.Modid)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modid");
            entity.Property(e => e.IsMobMod).HasColumnName("is_mob_mod");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MobSpawnPoint>(entity =>
        {
            entity.HasKey(e => e.Mobid).HasName("PRIMARY");

            entity.ToTable("mob_spawn_points");

            entity.Property(e => e.Mobid)
                .ValueGeneratedNever()
                .HasColumnType("int(10)")
                .HasColumnName("mobid");
            entity.Property(e => e.Groupid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("groupid");
            entity.Property(e => e.Mobname)
                .HasMaxLength(24)
                .HasColumnName("mobname");
            entity.Property(e => e.PolutilsName)
                .HasMaxLength(50)
                .HasColumnName("polutils_name");
            entity.Property(e => e.PosRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pos_rot");
            entity.Property(e => e.PosX)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_x");
            entity.Property(e => e.PosY)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_y");
            entity.Property(e => e.PosZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_z");
        });

        modelBuilder.Entity<MobSpellList>(entity =>
        {
            entity.HasKey(e => new { e.SpellListId, e.SpellId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("mob_spell_lists");

            entity.Property(e => e.SpellListId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("spell_list_id");
            entity.Property(e => e.SpellId)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("spell_id");
            entity.Property(e => e.MaxLevel)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("max_level");
            entity.Property(e => e.MinLevel)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("min_level");
            entity.Property(e => e.SpellListName)
                .HasMaxLength(30)
                .HasColumnName("spell_list_name");
        });

        modelBuilder.Entity<MonstrosityExpTable>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("monstrosity_exp_table");

            entity.Property(e => e.Level)
                .ValueGeneratedNever()
                .HasColumnType("tinyint(2)")
                .HasColumnName("level");
            entity.Property(e => e.Amount)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("amount");
        });

        modelBuilder.Entity<MonstrosityInstinct>(entity =>
        {
            entity.HasKey(e => e.MonstrosityInstinctId).HasName("PRIMARY");

            entity.ToTable("monstrosity_instincts");

            entity.Property(e => e.MonstrosityInstinctId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(30) unsigned")
                .HasColumnName("monstrosity_instinct_id");
            entity.Property(e => e.Cost)
                .HasColumnType("smallint(30) unsigned")
                .HasColumnName("cost");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MonstrosityInstinctMod>(entity =>
        {
            entity.HasKey(e => new { e.MonstrosityInstinctId, e.ModId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("monstrosity_instinct_mods");

            entity.Property(e => e.MonstrosityInstinctId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("monstrosity_instinct_id");
            entity.Property(e => e.ModId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modId");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MonstrositySpecy>(entity =>
        {
            entity.HasKey(e => new { e.MonstrosityId, e.MonstrositySpeciesCode })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("monstrosity_species");

            entity.Property(e => e.MonstrosityId)
                .HasColumnType("smallint(30) unsigned")
                .HasColumnName("monstrosity_id");
            entity.Property(e => e.MonstrositySpeciesCode)
                .HasColumnType("smallint(30) unsigned")
                .HasColumnName("monstrosity_species_code");
            entity.Property(e => e.Look)
                .HasMaxLength(4)
                .HasColumnName("look");
            entity.Property(e => e.Mjob)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("mjob");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.Size)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("size");
            entity.Property(e => e.Sjob)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("sjob");
        });

        modelBuilder.Entity<NmSpawnPoint>(entity =>
        {
            entity.HasKey(e => new { e.Mobid, e.Pos })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("nm_spawn_points");

            entity.Property(e => e.Mobid)
                .HasColumnType("int(10)")
                .HasColumnName("mobid");
            entity.Property(e => e.Pos)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pos");
            entity.Property(e => e.PosX)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_x");
            entity.Property(e => e.PosY)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_y");
            entity.Property(e => e.PosZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_z");
        });

        modelBuilder.Entity<NpcList>(entity =>
        {
            entity.HasKey(e => e.Npcid).HasName("PRIMARY");

            entity.ToTable("npc_list");

            entity.Property(e => e.Npcid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("npcid");
            entity.Property(e => e.Animation)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("animation");
            entity.Property(e => e.Animationsub)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("animationsub");
            entity.Property(e => e.ContentTag)
                .HasMaxLength(14)
                .HasColumnName("content_tag");
            entity.Property(e => e.EntityFlags)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("entityFlags");
            entity.Property(e => e.Flag)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("flag");
            entity.Property(e => e.Look)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("look");
            entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasColumnName("name");
            entity.Property(e => e.NamePrefix)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("name_prefix");
            entity.Property(e => e.Namevis)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("namevis");
            entity.Property(e => e.PolutilsName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("polutils_name");
            entity.Property(e => e.PosRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pos_rot");
            entity.Property(e => e.PosX)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_x");
            entity.Property(e => e.PosY)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_y");
            entity.Property(e => e.PosZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("pos_z");
            entity.Property(e => e.Speed)
                .HasDefaultValueSql("'40'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("speed");
            entity.Property(e => e.Speedsub)
                .HasDefaultValueSql("'40'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("speedsub");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("status");
            entity.Property(e => e.Widescan)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("widescan");
        });

        modelBuilder.Entity<PetList>(entity =>
        {
            entity.HasKey(e => e.Petid).HasName("PRIMARY");

            entity.ToTable("pet_list");

            entity.Property(e => e.Petid)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("petid");
            entity.Property(e => e.DamageType)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("damageType");
            entity.Property(e => e.Element)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("element");
            entity.Property(e => e.MaxLevel)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("maxLevel");
            entity.Property(e => e.MinLevel)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("minLevel");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Poolid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("poolid");
            entity.Property(e => e.Time)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("time");
        });

        modelBuilder.Entity<PetName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pet_name");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<PetSkill>(entity =>
        {
            entity.HasKey(e => e.PetSkillId).HasName("PRIMARY");

            entity.ToTable("pet_skills");

            entity.Property(e => e.PetSkillId)
                .ValueGeneratedNever()
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_skill_id");
            entity.Property(e => e.Knockback).HasColumnName("knockback");
            entity.Property(e => e.PetAnimId)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_anim_id");
            entity.Property(e => e.PetAnimTime)
                .HasDefaultValueSql("'2000'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_anim_time");
            entity.Property(e => e.PetMessage)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("pet_message");
            entity.Property(e => e.PetPrepareTime)
                .HasDefaultValueSql("'1000'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_prepare_time");
            entity.Property(e => e.PetSkillAoe)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("pet_skill_aoe");
            entity.Property(e => e.PetSkillDistance)
                .HasDefaultValueSql("'6.0'")
                .HasColumnType("float(3,1)")
                .HasColumnName("pet_skill_distance");
            entity.Property(e => e.PetSkillFinishCategory)
                .HasDefaultValueSql("'11'")
                .HasColumnType("smallint(5)")
                .HasColumnName("pet_skill_finish_category");
            entity.Property(e => e.PetSkillFlag)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("pet_skill_flag");
            entity.Property(e => e.PetSkillName)
                .HasMaxLength(40)
                .HasColumnName("pet_skill_name")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.PetSkillParam)
                .HasColumnType("smallint(5)")
                .HasColumnName("pet_skill_param");
            entity.Property(e => e.PetValidTargets)
                .HasDefaultValueSql("'4'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("pet_valid_targets");
            entity.Property(e => e.PrimarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("primary_sc");
            entity.Property(e => e.SecondarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("secondary_sc");
            entity.Property(e => e.TertiarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("tertiary_sc");
        });

        modelBuilder.Entity<ServerVariable>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("server_variables");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Expiry)
                .HasColumnType("int(11)")
                .HasColumnName("expiry");
            entity.Property(e => e.Value)
                .HasColumnType("int(11)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<SkillCap>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("skill_caps");

            entity.Property(e => e.Level)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.R0)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r0");
            entity.Property(e => e.R1)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r1");
            entity.Property(e => e.R10)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r10");
            entity.Property(e => e.R11)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r11");
            entity.Property(e => e.R12)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r12");
            entity.Property(e => e.R13)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r13");
            entity.Property(e => e.R2)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r2");
            entity.Property(e => e.R3)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r3");
            entity.Property(e => e.R4)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r4");
            entity.Property(e => e.R5)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r5");
            entity.Property(e => e.R6)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r6");
            entity.Property(e => e.R7)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r7");
            entity.Property(e => e.R8)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r8");
            entity.Property(e => e.R9)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("r9");
        });

        modelBuilder.Entity<SkillRank>(entity =>
        {
            entity.HasKey(e => e.Skillid).HasName("PRIMARY");

            entity.ToTable("skill_ranks");

            entity.Property(e => e.Skillid)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("skillid");
            entity.Property(e => e.Blm)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("blm");
            entity.Property(e => e.Blu)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("blu");
            entity.Property(e => e.Brd)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("brd");
            entity.Property(e => e.Bst)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("bst");
            entity.Property(e => e.Cor)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("cor");
            entity.Property(e => e.Dnc)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("dnc");
            entity.Property(e => e.Drg)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("drg");
            entity.Property(e => e.Drk)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("drk");
            entity.Property(e => e.Geo)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("geo");
            entity.Property(e => e.Mnk)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("mnk");
            entity.Property(e => e.Name)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Nin)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("nin");
            entity.Property(e => e.Pld)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("pld");
            entity.Property(e => e.Pup)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("pup");
            entity.Property(e => e.Rdm)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rdm");
            entity.Property(e => e.Rng)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rng");
            entity.Property(e => e.Run)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("run");
            entity.Property(e => e.Sam)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sam");
            entity.Property(e => e.Sch)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("sch");
            entity.Property(e => e.Smn)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("smn");
            entity.Property(e => e.Thf)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("thf");
            entity.Property(e => e.War)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("war");
            entity.Property(e => e.Whm)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("whm");
        });

        modelBuilder.Entity<SkillchainDamageModifier>(entity =>
        {
            entity.HasKey(e => new { e.ChainLevel, e.ChainCount })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("skillchain_damage_modifiers");

            entity.Property(e => e.ChainLevel)
                .HasDefaultValueSql("'1'")
                .HasColumnType("enum('1','2','3','4')")
                .HasColumnName("chain_level");
            entity.Property(e => e.ChainCount)
                .HasDefaultValueSql("'1'")
                .HasColumnType("enum('1','2','3','4','5')")
                .HasColumnName("chain_count");
            entity.Property(e => e.InitialModifier)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(3)")
                .HasColumnName("initial_modifier");
            entity.Property(e => e.MagicBurstModifier)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(3)")
                .HasColumnName("magic_burst_modifier");
        });

        modelBuilder.Entity<SpellList>(entity =>
        {
            entity.HasKey(e => e.Spellid).HasName("PRIMARY");

            entity.ToTable("spell_list");

            entity.Property(e => e.Spellid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("spellid");
            entity.Property(e => e.Animation)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("animation");
            entity.Property(e => e.AnimationTime)
                .HasDefaultValueSql("'2000'")
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("animationTime");
            entity.Property(e => e.Aoe)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("AOE");
            entity.Property(e => e.Base)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("base");
            entity.Property(e => e.CastTime)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("castTime");
            entity.Property(e => e.Ce)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("CE");
            entity.Property(e => e.ContentTag)
                .HasMaxLength(7)
                .HasColumnName("content_tag");
            entity.Property(e => e.Element)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("element");
            entity.Property(e => e.Family)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("family");
            entity.Property(e => e.Group)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("group");
            entity.Property(e => e.Jobs)
                .HasMaxLength(22)
                .IsFixedLength()
                .HasColumnName("jobs");
            entity.Property(e => e.MagicBurstMessage)
                .HasColumnType("smallint(5)")
                .HasColumnName("magicBurstMessage");
            entity.Property(e => e.Message)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("message");
            entity.Property(e => e.MpCost)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("mpCost");
            entity.Property(e => e.Multiplier)
                .HasDefaultValueSql("'1.00'")
                .HasColumnType("float(4,2)")
                .HasColumnName("multiplier");
            entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasColumnName("name");
            entity.Property(e => e.RecastTime)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("recastTime");
            entity.Property(e => e.Requirements)
                .HasColumnType("tinyint(2)")
                .HasColumnName("requirements");
            entity.Property(e => e.Skill)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("skill");
            entity.Property(e => e.SpellRange)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("spell_range");
            entity.Property(e => e.ValidTargets)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("validTargets");
            entity.Property(e => e.Ve)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("VE");
            entity.Property(e => e.Zonemisc)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zonemisc");
        });

        modelBuilder.Entity<StatusEffect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("status_effects");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.BlockId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("block_id");
            entity.Property(e => e.Element)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("element");
            entity.Property(e => e.Flags)
                .HasColumnType("int(8) unsigned")
                .HasColumnName("flags");
            entity.Property(e => e.MinDuration)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("min_duration");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.NegativeId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("negative_id");
            entity.Property(e => e.Overwrite)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("overwrite");
            entity.Property(e => e.RemoveId)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("remove_id");
            entity.Property(e => e.SortKey)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("sort_key");
            entity.Property(e => e.Type)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("type");
        });

        modelBuilder.Entity<SynthRecipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("synth_recipes");

            entity.Property(e => e.Id)
                .HasColumnType("mediumint(5) unsigned")
                .HasColumnName("ID");
            entity.Property(e => e.Alchemy).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Bone).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Cloth).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Cook).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Crystal).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Desynth).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Gold).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Hqcrystal)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("HQCrystal");
            entity.Property(e => e.Ingredient1).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient2).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient3).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient4).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient5).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient6).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient7).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.Ingredient8).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.KeyItem).HasColumnType("int(10) unsigned");
            entity.Property(e => e.Leather).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Result).HasColumnType("smallint(5) unsigned");
            entity.Property(e => e.ResultHq1)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ResultHQ1");
            entity.Property(e => e.ResultHq1qty)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("ResultHQ1Qty");
            entity.Property(e => e.ResultHq2)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ResultHQ2");
            entity.Property(e => e.ResultHq2qty)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("ResultHQ2Qty");
            entity.Property(e => e.ResultHq3)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("ResultHQ3");
            entity.Property(e => e.ResultHq3qty)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("ResultHQ3Qty");
            entity.Property(e => e.ResultName).HasColumnType("tinytext");
            entity.Property(e => e.ResultQty).HasColumnType("tinyint(2) unsigned");
            entity.Property(e => e.Smith).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.Wood).HasColumnType("tinyint(3) unsigned");
        });

        modelBuilder.Entity<Trait>(entity =>
        {
            entity.HasKey(e => new { e.Traitid, e.Job, e.Level, e.Rank, e.Modifier })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.ToTable("traits");

            entity.Property(e => e.Traitid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("traitid");
            entity.Property(e => e.Job)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("job");
            entity.Property(e => e.Level)
                .HasDefaultValueSql("'99'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.Rank)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("rank");
            entity.Property(e => e.Modifier)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("modifier");
            entity.Property(e => e.ContentTag)
                .HasMaxLength(7)
                .HasColumnName("content_tag");
            entity.Property(e => e.Meritid)
                .HasColumnType("smallint(5)")
                .HasColumnName("meritid");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasColumnType("smallint(5)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Transport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("transport");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.AnimArrive)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("anim_arrive");
            entity.Property(e => e.AnimDepart)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("anim_depart");
            entity.Property(e => e.Boundary)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("boundary");
            entity.Property(e => e.DockRot)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("dock_rot");
            entity.Property(e => e.DockX)
                .HasColumnType("float(7,3)")
                .HasColumnName("dock_x");
            entity.Property(e => e.DockY)
                .HasColumnType("float(7,3)")
                .HasColumnName("dock_y");
            entity.Property(e => e.DockZ)
                .HasColumnType("float(7,3)")
                .HasColumnName("dock_z");
            entity.Property(e => e.Door)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("door");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.TimeAnimArrive)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("time_anim_arrive");
            entity.Property(e => e.TimeAnimDepart)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("time_anim_depart");
            entity.Property(e => e.TimeInterval)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("time_interval");
            entity.Property(e => e.TimeOffset)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("time_offset");
            entity.Property(e => e.TimeWaiting)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("time_waiting");
            entity.Property(e => e.Transport1)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("transport");
            entity.Property(e => e.Zone)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("zone");
        });

        modelBuilder.Entity<UnitySystem>(entity =>
        {
            entity.HasKey(e => e.Leader).HasName("PRIMARY");

            entity.ToTable("unity_system");

            entity.Property(e => e.Leader)
                .ValueGeneratedNever()
                .HasColumnType("tinyint(4)")
                .HasColumnName("leader");
            entity.Property(e => e.MembersCurrent)
                .HasColumnType("int(11)")
                .HasColumnName("members_current");
            entity.Property(e => e.MembersPrev)
                .HasColumnType("int(11)")
                .HasColumnName("members_prev");
            entity.Property(e => e.PointsCurrent).HasColumnName("points_current");
            entity.Property(e => e.PointsPrev).HasColumnName("points_prev");
        });

        modelBuilder.Entity<WaterPoint>(entity =>
        {
            entity.HasKey(e => e.Waterid).HasName("PRIMARY");

            entity.ToTable("water_points");

            entity.Property(e => e.Waterid)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("waterid");
            entity.Property(e => e.Pointid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("pointid");
            entity.Property(e => e.PosX)
                .HasColumnType("float(7,2)")
                .HasColumnName("pos_x");
            entity.Property(e => e.PosY)
                .HasColumnType("float(7,2)")
                .HasColumnName("pos_y");
            entity.Property(e => e.PosZ)
                .HasColumnType("float(7,2)")
                .HasColumnName("pos_z");
            entity.Property(e => e.Type)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("type");
            entity.Property(e => e.Zoneid)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("zoneid");
        });

        modelBuilder.Entity<WeaponSkill>(entity =>
        {
            entity.HasKey(e => e.Weaponskillid).HasName("PRIMARY");

            entity.ToTable("weapon_skills");

            entity.Property(e => e.Weaponskillid)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("weaponskillid");
            entity.Property(e => e.Animation)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("animation");
            entity.Property(e => e.AnimationTime)
                .HasColumnType("smallint(4) unsigned")
                .HasColumnName("animationTime");
            entity.Property(e => e.Aoe)
                .HasColumnType("tinyint(1) unsigned")
                .HasColumnName("aoe");
            entity.Property(e => e.Element)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("element");
            entity.Property(e => e.Jobs)
                .HasMaxLength(22)
                .IsFixedLength()
                .HasColumnName("jobs");
            entity.Property(e => e.MainOnly).HasColumnName("main_only");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.PrimarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("primary_sc");
            entity.Property(e => e.Range)
                .HasDefaultValueSql("'5'")
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("range");
            entity.Property(e => e.SecondarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("secondary_sc");
            entity.Property(e => e.Skilllevel)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("skilllevel");
            entity.Property(e => e.TertiarySc)
                .HasColumnType("tinyint(4)")
                .HasColumnName("tertiary_sc");
            entity.Property(e => e.Type)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("type");
            entity.Property(e => e.UnlockId)
                .HasColumnType("tinyint(2)")
                .HasColumnName("unlock_id");
        });

        modelBuilder.Entity<ZoneSetting>(entity =>
        {
            entity.HasKey(e => e.Zoneid).HasName("PRIMARY");

            entity.ToTable("zone_settings");

            entity.Property(e => e.Zoneid)
                .ValueGeneratedNever()
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("zoneid");
            entity.Property(e => e.Battlemulti)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("battlemulti");
            entity.Property(e => e.Battlesolo)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("battlesolo");
            entity.Property(e => e.Misc)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("misc");
            entity.Property(e => e.MusicDay)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("music_day");
            entity.Property(e => e.MusicNight)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("music_night");
            entity.Property(e => e.Name)
                .HasColumnType("tinytext")
                .HasColumnName("name");
            entity.Property(e => e.Restriction)
                .HasColumnType("tinyint(2) unsigned")
                .HasColumnName("restriction");
            entity.Property(e => e.Tax)
                .HasColumnType("float(5,2) unsigned")
                .HasColumnName("tax");
            entity.Property(e => e.Zoneip)
                .HasColumnType("tinytext")
                .HasColumnName("zoneip");
            entity.Property(e => e.Zoneport)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zoneport");
            entity.Property(e => e.Zonetype)
                .HasColumnType("smallint(5) unsigned")
                .HasColumnName("zonetype");
        });

        modelBuilder.Entity<ZoneWeather>(entity =>
        {
            entity.HasKey(e => e.Zone).HasName("PRIMARY");

            entity.ToTable("zone_weather");

            entity.HasIndex(e => e.Zone, "zone").IsUnique();

            entity.Property(e => e.Zone)
                .ValueGeneratedNever()
                .HasColumnType("smallint(5)")
                .HasColumnName("zone");
            entity.Property(e => e.Weather)
                .HasMaxLength(4320)
                .HasColumnName("weather");
        });

        modelBuilder.Entity<Zoneline>(entity =>
        {
            entity.HasKey(e => e.Zoneline1).HasName("PRIMARY");

            entity.ToTable("zonelines");

            entity.Property(e => e.Zoneline1)
                .ValueGeneratedNever()
                .HasColumnType("int(10) unsigned")
                .HasColumnName("zoneline");
            entity.Property(e => e.Fromzone)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("fromzone");
            entity.Property(e => e.Rotation)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("rotation");
            entity.Property(e => e.Tox)
                .HasColumnType("float(7,3)")
                .HasColumnName("tox");
            entity.Property(e => e.Toy)
                .HasColumnType("float(7,3)")
                .HasColumnName("toy");
            entity.Property(e => e.Toz)
                .HasColumnType("float(7,3)")
                .HasColumnName("toz");
            entity.Property(e => e.Tozone)
                .HasColumnType("smallint(3) unsigned")
                .HasColumnName("tozone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
