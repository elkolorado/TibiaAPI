﻿using System;
using System.Collections.Generic;

using OXGaming.TibiaAPI.Appearances;
using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ServerPackets
{
    public class CyclopediaCharacterInfo : ServerPacket
    {
        public List<byte> HirelingJobIds { get; } = new List<byte>();
        // TODO: I'm assuming these are byte IDs like Jobs above; need to confirm.
        public List<byte> HirelingOutfitIds { get; } = new List<byte>();

        public List<(string Name, byte Amount)> Blessings { get; } =
            new List<(string Name, byte Amount)>();

        public List<(byte Type, byte Amount)> DamageReductions { get; } =
            new List<(byte Type, byte Amount)>();

        public List<(ushort Id, uint Amount)> DepotItems { get; } =
            new List<(ushort Id, uint Amount)>();
        public List<(ushort Id, uint Amount)> InboxItems { get; } =
            new List<(ushort Id, uint Amount)>();
        public List<(ushort Id, uint Amount)> InventoryItems { get; } =
            new List<(ushort Id, uint Amount)>();
        public List<(ushort Id, uint Amount)> StashItems { get; } =
            new List<(ushort Id, uint Amount)>();
        public List<(ushort Id, uint Amount)> StoreInboxItems { get; } =
            new List<(ushort Id, uint Amount)>();
        public List<(ushort Id, ushort Time)> Concotions { get; } =
            new List<(ushort Id, ushort Time)>();

        public List<(uint Id, string Name)> Badges { get; } =
            new List<(uint Id, string Name)>();
        public List<(byte Id, string Name, string Description, bool Permanent, bool Unlocked)> Titles { get; } =
            new List<(byte Id, string Name, string Description, bool Permanent, bool Unlocked)>();

        public List<(string Name, string Description)> PlayerDetails { get; } =
            new List<(string Name, string Description)>();

        public List<(uint Timestamp, string Cause)> RecentDeaths { get; } =
            new List<(uint Timestamp, string Cause)>();
        public List<(uint Timestamp, string Description, byte Status)> RecentPvpKills { get; } =
            new List<(uint Timestamp, string Description, byte Status)>();

        public List<(ushort Id, string Name, byte Category, uint Unknown)> Mounts { get; } =
            new List<(ushort Id, string Name, byte Category, uint Unknown)>();
        public List<(ushort Id, string Name, byte Category, uint Unknown)> Familiars { get; } =
            new List<(ushort Id, string Name, byte Category, uint Unknown)>();
        public List<(ushort Id, string Name, byte Addons, byte Category, uint Unknown)> Outfits { get; } =
            new List<(ushort Id, string Name, byte Addons, byte Category, uint Unknown)>();

        public List<(byte Type, ushort Level, ushort Base, ushort Loyalty, ushort Progress)> Skills { get; } =
            new List<(byte Type, ushort Level, ushort Base, ushort Loyalty, ushort Progress)>();

        public List<(ushort Id, uint Timestamp, bool IsSecret, string Name, string Description, byte Grade)> UnlockedAchievements { get; } =
            new List<(ushort Id, uint Timestamp, bool IsSecret, string Name, string Description, byte Grade)>();

        public List<(string Name, byte Slot, ObjectInstance Item, List<ushort> ImbuementIds, List<(string Name, string Description)> Details)> InspectionItems { get; } =
            new List<(string Name, byte Slot, ObjectInstance Item, List<ushort> ImbuementIds, List<(string Name, string Description)> Details)>();

        public List<ushort> PerfectShot { get; } =
            new List<ushort>();


        public AppearanceInstance Outfit { get; set; }

        public string LoyaltyTitle { get; set; }
        public string PlayerName { get; set; }
        public String Title { get; set; }
        public string Vocation { get; set; }

        public ulong Experience { get; set; }

        public uint CapacityBonus { get; set; }
        public uint CapacityCurrent { get; set; }
        public uint CapacityMax { get; set; }
        public uint RemainingDailyRewardXpBoostTime { get; set; }
        public uint RemainingStoreXpBoostTime { get; set; }
        public uint TournamentFactor { get; set; }
        public uint HealthCurrent { get; set; }
        public uint HealthMax { get; set; }
        public uint ManaCurrent { get; set; }
        public uint ManaMax { get; set; }

        public ushort AchievementPoints { get; set; }
        public ushort Armor { get; set; }
        public ushort Attack { get; set; }
        public ushort BaseXpGain { get; set; }
        public ushort CriticalHitChancePercentBase { get; set; }
        public ushort CriticalHitChancePercentBonus { get; set; }
        public ushort CriticalHitExtraDamagePercentBase { get; set; }
        public ushort CriticalHitExtraDamagePercentBonus { get; set; }
        public ushort Defense { get; set; }
        public ushort Food { get; set; }
        public ushort GrindingAddend { get; set; }
        public ushort HuntingBoostFactor { get; set; }
        public ushort Level { get; set; }
        public ushort LevelDisplay { get; set; }
        public ushort LifeLeechAmountPercentBase { get; set; }
        public ushort LifeLeechAmountPercentBonus { get; set; }
        public ushort LifeLeechChancePercentBase { get; set; }
        public ushort LifeLeechChancePercentBonus { get; set; }
        public ushort ManaLeechAmountPercentBase { get; set; }
        public ushort ManaLeechAmountPercentBonus { get; set; }
        public ushort ManaLeechChancePercentBase { get; set; }
        public ushort ManaLeechChancePercentBonus { get; set; }
        public ushort OfflineTrainingTime { get; set; }
        public ushort PurchasedHouseItems { get; set; }
        public ushort RecentDeathsPageCurrent { get; set; }
        public ushort RecentDeathsPageMax { get; set; }
        public ushort RecentPvpKillsPageCurrent { get; set; }
        public ushort RecentPvpKillsPageMax { get; set; }
        public ushort SecretAchievementsMax { get; set; }
        public ushort SpeedBase { get; set; }
        public ushort SpeedCurrent { get; set; }
        public ushort Stamina { get; set; }
        public ushort StoreXpBoostAddend { get; set; }
        public ushort StoreXpBoostTime { get; set; }
        public ushort MagicBoostValue { get; set; }
        public ushort Cleave { get; set; }
        public ushort MagicShieldBonus { get; set; }
        public ushort MagicShieldPercentage { get; set; }
        public ushort Reflection { get; set; }

        public ushort UnknownU16One { get; set; }
        public ushort UnknownU16Two { get; set; }
        public ushort UnknownU16Three { get; set; }
        public ushort UnknownU16Four { get; set; }
        public ushort UnknownU16Five { get; set; }
        public ushort UnknownU16Six { get; set; }

        public byte AttackType { get; set; }
        public byte BlessingsCurrent { get; set; }
        public byte BlessingsMax { get; set; }
        public byte CharmExpansion { get; set; }
        public byte ConvertedDamagePercent { get; set; }
        public byte ConvertedDamageType { get; set; }
        public byte CurrentCharacterTitle { get; set; }
        public byte DetailColor { get; set; }
        public byte Error { get; set; }
        public byte HeadColor { get; set; }
        public byte InstantRewardAccess { get; set; }
        public byte LegsColor { get; set; }
        public byte LevelPercent { get; set; }
        public byte PermanentPreySlots { get; set; }
        public byte PreyWildcards { get; set; }
        public byte PurchasedHirelings { get; set; }
        public byte Soul { get; set; }
        public byte TorsoColor { get; set; }
        public byte Type { get; set; }
        public byte MountHeadColor { get; set; }
        public byte MountTorsoColor { get; set; }
        public byte MountLegsColor { get; set; }
        public byte MountDetailColor { get; set; }
					
        public bool HideStamina { get; set; }
        public bool IsOnline { get; set; }
        public bool IsPremium { get; set; }
        public bool ShowAccountInformation { get; set; }
        public bool ShowPersonalTabs { get; set; }
        public bool ShowStoreXpBoostButton { get; set; }
        public bool MagicBoost { get; set; }

        public ElementType MagicBoostElement { get; set; }

        public CyclopediaCharacterInfo(Client client)
        {
            Client = client;
            PacketType = ServerPacketType.CyclopediaCharacterInfo;
        }

        public override void ParseFromNetworkMessage(NetworkMessage message)
        {
            Type = message.ReadByte();
			
            // 1: No data available at the moment.
            // 2: You are not allowed to see this character's data.
            // 3: You are not allowed to inspect this character.
            Error = message.ReadByte();
            if (Error != 0)
				return;
			
            if (Type == (byte)CharacterInfoPage.Basic) {
                PlayerName = message.ReadString();
                Vocation = message.ReadString();
                LevelDisplay = message.ReadUInt16();
                Outfit = message.ReadCreatureOutfit();
				
                // This may also indicate Tournament characters
                HideStamina = message.ReadBool();
				
                // Shows the Story Summary and Character Titles tabs
                ShowPersonalTabs = message.ReadBool();
                Title = message.ReadString();
            } else if (Type == (byte)CharacterInfoPage.Stats) {
                Experience = message.ReadUInt64();
                Level = message.ReadUInt16();
                LevelPercent = message.ReadByte();
                BaseXpGain = message.ReadUInt16();
                TournamentFactor = message.ReadUInt32();
                GrindingAddend = message.ReadUInt16();
                StoreXpBoostAddend = message.ReadUInt16();
                HuntingBoostFactor = message.ReadUInt16();
                StoreXpBoostTime = message.ReadUInt16();
                ShowStoreXpBoostButton = message.ReadBool();
                HealthCurrent = message.ReadUInt32();
                HealthMax = message.ReadUInt32();
                ManaCurrent = message.ReadUInt32();
                ManaMax = message.ReadUInt32();
                Soul = message.ReadByte();
                Stamina = message.ReadUInt16();
                Food = message.ReadUInt16();
                OfflineTrainingTime = message.ReadUInt16();
                SpeedCurrent = message.ReadUInt16();
                SpeedBase = message.ReadUInt16();
                CapacityBonus = message.ReadUInt32();
                CapacityCurrent = message.ReadUInt32();
                CapacityMax = message.ReadUInt32();

                Skills.Capacity = message.ReadByte();
                for (var i = 0; i < Skills.Capacity; ++i)
                    Skills.Add((message.ReadByte(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16()));
				
				MagicBoost = message.ReadBool();
				if (MagicBoost) {
					MagicBoostElement = (ElementType)message.ReadByte();
					MagicBoostValue = message.ReadUInt16();
				}
			} else if (Type == (byte)CharacterInfoPage.Combat) {
				// To-Do: Group all as enum skills
                CriticalHitChancePercentBase = message.ReadUInt16();
                CriticalHitChancePercentBonus = message.ReadUInt16();
				
                CriticalHitExtraDamagePercentBase = message.ReadUInt16();
                CriticalHitExtraDamagePercentBonus = message.ReadUInt16();
				
                LifeLeechChancePercentBase = message.ReadUInt16();
                LifeLeechChancePercentBonus = message.ReadUInt16();
				
                LifeLeechAmountPercentBase = message.ReadUInt16();
                LifeLeechAmountPercentBonus = message.ReadUInt16();
				
                ManaLeechChancePercentBase = message.ReadUInt16();
                ManaLeechChancePercentBonus = message.ReadUInt16();
				
                ManaLeechAmountPercentBase = message.ReadUInt16();
                ManaLeechAmountPercentBonus = message.ReadUInt16();

                UnknownU16One = message.ReadUInt16();
                UnknownU16Two = message.ReadUInt16();
                UnknownU16Three = message.ReadUInt16();
                UnknownU16Four = message.ReadUInt16();
                UnknownU16Five = message.ReadUInt16();
                UnknownU16Six = message.ReadUInt16();

                Cleave = message.ReadUInt16();
                MagicShieldBonus = message.ReadUInt16();
                MagicShieldPercentage = message.ReadUInt16();
				
                for (int i = 1; i <= 5; i++) {
                    var range = message.ReadUInt16();
                    PerfectShot.Add(range);
                }
				
                Reflection = message.ReadUInt16();
                BlessingsCurrent = message.ReadByte();
                BlessingsMax = message.ReadByte();
                Attack = message.ReadUInt16();
                AttackType = message.ReadByte();
                ConvertedDamagePercent = message.ReadByte();
                ConvertedDamageType = message.ReadByte();
                Armor = message.ReadUInt16();
                Defense = message.ReadUInt16();

                DamageReductions.Capacity = message.ReadByte();
                for (var i = 0; i < DamageReductions.Capacity; ++i)
                    DamageReductions.Add((message.ReadByte(), message.ReadByte()));
                    Concotions.Capacity = message.ReadByte();
                    for (var i = 0; i < Concotions.Capacity; ++i)
                    Concotions.Add((message.ReadUInt16(), message.ReadUInt16()));

            } else if (Type == (byte)CharacterInfoPage.Deaths) {
                RecentDeathsPageCurrent = message.ReadUInt16();
                RecentDeathsPageMax = message.ReadUInt16();

                RecentDeaths.Capacity = message.ReadUInt16();
                for (var i = 0; i < RecentDeaths.Capacity; ++i)
                    RecentDeaths.Add((message.ReadUInt32(), message.ReadString()));
				
            } else if (Type == (byte)CharacterInfoPage.Pvp) {
                RecentPvpKillsPageCurrent = message.ReadUInt16();
                RecentPvpKillsPageMax = message.ReadUInt16();

                RecentPvpKills.Capacity = message.ReadUInt16();
                for (var i = 0; i < RecentPvpKills.Capacity; ++i)
                    RecentPvpKills.Add((message.ReadUInt32(), message.ReadString(), message.ReadByte()));

            } else if (Type == (byte)CharacterInfoPage.Achiev) {
                AchievementPoints = message.ReadUInt16();
                SecretAchievementsMax = message.ReadUInt16();

                UnlockedAchievements.Capacity = message.ReadUInt16();
                for (var i = 0; i < UnlockedAchievements.Capacity; ++i) {
                    var id = message.ReadUInt16();
                    var timestamp = message.ReadUInt32();
                    var name = string.Empty;
                    var description = string.Empty;
                    var grade = byte.MinValue;
                    var isSecret = message.ReadBool();
                    if (isSecret) {
                        name = message.ReadString();
                        description = message.ReadString();
                        grade = message.ReadByte();
                    }
                    UnlockedAchievements.Add((id, timestamp, isSecret, name, description, grade));
                }
            } else if (Type == (byte)CharacterInfoPage.Items) {
                void ParseItems(List<(ushort, uint)> items)
                {
                    items.Clear();
                    items.Capacity = message.ReadUInt16();
                    for (var i = 0; i < items.Capacity; ++i) {
                        var id = message.ReadUInt16();
                        var amount = message.ReadUInt32();
                        items.Add((id, amount));
                    }
                }

                ParseItems(InventoryItems);
                ParseItems(StoreInboxItems);
                ParseItems(StashItems);
                ParseItems(DepotItems);
                ParseItems(InboxItems);
            } else if (Type == (byte)CharacterInfoPage.Outfits) {
                Outfits.Clear();
                Outfits.Capacity = message.ReadUInt16();
                for (var i = 0; i < Outfits.Capacity; ++i) {
                    var id = message.ReadUInt16();
                    var name = message.ReadString();
                    var addons = message.ReadByte();
                    // 0 = Standard, 1 = Quest, 2 = Store
                    var category = message.ReadByte();
                    var unknown = message.ReadUInt32();
                    Outfits.Add((id, name, addons, category, unknown));
                }
				
                if (Outfits.Capacity > 0) {
                    HeadColor = message.ReadByte();
                    TorsoColor = message.ReadByte();
                    LegsColor = message.ReadByte();
                    DetailColor = message.ReadByte();
                }
				
                Mounts.Clear();
                Mounts.Capacity = message.ReadUInt16();
                for (var i = 0; i < Mounts.Capacity; ++i) {
                    var id = message.ReadUInt16();
                    var name = message.ReadString();
					
                    // 0 = Standard, 1 = Quest, 2 = Store
                    var category = message.ReadByte();
                    var unknown = message.ReadUInt32();
                    Mounts.Add((id, name, category, unknown));
                }
				
                if (Mounts.Capacity > 0) {
                    MountHeadColor = message.ReadByte();
                    MountTorsoColor = message.ReadByte();
                    MountLegsColor = message.ReadByte();
                    MountDetailColor = message.ReadByte();
                }
				
                Familiars.Capacity = message.ReadUInt16();
                for (var i = 0; i < Familiars.Capacity; ++i) {
                    var id = message.ReadUInt16();
                    var name = message.ReadString();
					
                    // 0 = Standard, 1 = Quest, 2 = Store
                    var category = message.ReadByte();
                    var unknown = message.ReadUInt32();
                    Familiars.Add((id, name, category, unknown));
				}
				
            } else if (Type == (byte)CharacterInfoPage.Store) {
                RemainingStoreXpBoostTime = message.ReadUInt32();
                RemainingDailyRewardXpBoostTime = message.ReadUInt32();
                Blessings.Clear();
                Blessings.Capacity = message.ReadByte();
                for (var i = 0; i < Blessings.Capacity; ++i) {
                    var name = message.ReadString();
                    var amount = message.ReadByte();
                    Blessings.Add((name, amount));
                }
                PermanentPreySlots = message.ReadByte();
                PreyWildcards = message.ReadByte();
                InstantRewardAccess = message.ReadByte();
                CharmExpansion = message.ReadByte();
                PurchasedHirelings = message.ReadByte();
                HirelingJobIds.Clear();
                HirelingJobIds.Capacity = message.ReadByte();
                for (var i = 0; i < HirelingJobIds.Capacity; ++i)
                    HirelingJobIds.Add(message.ReadByte());
				
                HirelingOutfitIds.Clear();
                HirelingOutfitIds.Capacity = message.ReadByte();
                for (var i = 0; i < HirelingJobIds.Capacity; ++i)
                    HirelingOutfitIds.Add(message.ReadByte());
					
                // This most certainly has information after it (Store IDs,
                // item IDs, names; something to identify them).
                PurchasedHouseItems = message.ReadUInt16();
            } else if (Type == (byte)CharacterInfoPage.Inspect) {
                InspectionItems.Capacity = message.ReadByte();
                for (var i = 0; i < InspectionItems.Capacity; ++i) {
                    var slotId = message.ReadByte();
                    var itemName = message.ReadString();
                    var item = message.ReadObjectInstance();

                    var imbuementIds = new List<ushort>(message.ReadByte());
                    for (var x = 0; x < imbuementIds.Capacity; ++x)
                        imbuementIds.Add(message.ReadUInt16());

                    var details = new List<(string, string)>(message.ReadByte());
                    for (var n = 0; n < details.Capacity; ++n) {
                        var name = message.ReadString();
                        var description = message.ReadString();
                        details.Add((name, description));
                    }

                    InspectionItems.Add((itemName, slotId, item, imbuementIds, details));
                }
                PlayerName = message.ReadString();
                Outfit = message.ReadCreatureOutfit();

                PlayerDetails.Capacity = message.ReadByte();
                for (var n = 0; n < PlayerDetails.Capacity; ++n) {
                    var name = message.ReadString();
                    var description = message.ReadString();
                    PlayerDetails.Add((name, description));
                }
            } else if (Type == (byte)CharacterInfoPage.Badges) {
                ShowAccountInformation = message.ReadBool();
                if (ShowAccountInformation) {
                    IsOnline = message.ReadBool();
                    IsPremium = message.ReadBool();
                    LoyaltyTitle = message.ReadString();
                    Badges.Capacity = message.ReadByte();
                    for (var i = 0; i < Badges.Capacity; ++i) {
                        var id = message.ReadUInt32();
                        var name = message.ReadString();
                        Badges.Add((id, name));
                    }
                }
            } else if (Type == (byte)CharacterInfoPage.Titles) {
                CurrentCharacterTitle = message.ReadByte();
                Titles.Capacity = message.ReadByte();
                for (var i = 0; i < Titles.Capacity; ++i) {
                    var id = message.ReadByte();
                    var name = message.ReadString();
                    var description = message.ReadString();
                    var permanent = message.ReadBool();
                    var unlocked = message.ReadBool();
                    Titles.Add((id, name, description, permanent, unlocked));
                }
            } else {
                throw new Exception($"[CyclopediaCharacterInfo.ParseFromNetworkMessage] Unknown 'CharacterInfoPage' type '{Type}'.");
			}
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ServerPacketType.CyclopediaCharacterInfo);
            message.Write(Type);
            message.Write(Error);
            if (Error != 0)
				return;
			
            if (Type == (byte)CharacterInfoPage.Basic)  {
                message.Write(PlayerName);
                message.Write(Vocation);
                message.Write(LevelDisplay);
                if (Outfit is OutfitInstance) {
                    message.Write((OutfitInstance)Outfit);
                } else {
                    message.Write((ushort)0);
                    message.Write((ushort)Outfit.Id);
                }
                message.Write(HideStamina);
                message.Write(ShowPersonalTabs);
                message.Write(Title);
            } else if (Type == (byte)CharacterInfoPage.Stats) {
                message.Write(Experience);
                message.Write(Level);
                message.Write(LevelPercent);
                message.Write(BaseXpGain);
                message.Write(TournamentFactor);
                message.Write(GrindingAddend);
                message.Write(StoreXpBoostAddend);
                message.Write(HuntingBoostFactor);
                message.Write(StoreXpBoostTime);
                message.Write(ShowStoreXpBoostButton);
                message.Write(HealthCurrent);
                message.Write(HealthMax);
                message.Write(ManaCurrent);
                message.Write(ManaMax);
                message.Write(Soul);
                message.Write(Stamina);
                message.Write(Food);
                message.Write(OfflineTrainingTime);
                message.Write(SpeedCurrent);
                message.Write(SpeedBase);
                message.Write(CapacityBonus);
                message.Write(CapacityCurrent);
                message.Write(CapacityMax);

                var count = Math.Min(Skills.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i) {
                    message.Write(Skills[i].Type);
                    message.Write(Skills[i].Level);
                    message.Write(Skills[i].Base);
                    message.Write(Skills[i].Loyalty);
                    message.Write(Skills[i].Progress);
                }
				
                message.Write(MagicBoost);
                if (MagicBoost) {
                    message.Write((byte)MagicBoostElement);
                    message.Write(MagicBoostValue);
                }
            } else if (Type == (byte)CharacterInfoPage.Combat) {
                message.Write(CriticalHitChancePercentBase);
                message.Write(CriticalHitChancePercentBonus);
                message.Write(CriticalHitExtraDamagePercentBase);
                message.Write(CriticalHitExtraDamagePercentBonus);
                message.Write(LifeLeechChancePercentBase);
                message.Write(LifeLeechChancePercentBonus);
                message.Write(LifeLeechAmountPercentBase);
                message.Write(LifeLeechAmountPercentBonus);
                message.Write(ManaLeechChancePercentBase);
                message.Write(ManaLeechChancePercentBonus);
                message.Write(LifeLeechAmountPercentBase);
                message.Write(LifeLeechAmountPercentBonus);

                message.Write(UnknownU16One);
                message.Write(UnknownU16Two);
                message.Write(UnknownU16Three);
                message.Write(UnknownU16Four);
                message.Write(UnknownU16Five);
                message.Write(UnknownU16Six);

                message.Write(Cleave);
                message.Write(MagicShieldBonus);
                message.Write(MagicShieldPercentage);
				
                foreach (var shot in PerfectShot)
                    message.Write(shot);
				
                message.Write(Reflection);
                message.Write(BlessingsCurrent);
                message.Write(BlessingsMax);
                message.Write(Attack);
                message.Write(AttackType);
                message.Write(ConvertedDamagePercent);
                message.Write(ConvertedDamageType);
                message.Write(Armor);
                message.Write(Defense);

                var count = Math.Min(DamageReductions.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i) {
                    message.Write(DamageReductions[i].Type);
                    message.Write(DamageReductions[i].Amount);
                }
				
                count = Math.Min(Concotions.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i) {
                    message.Write(Concotions[i].Id);
                    message.Write(Concotions[i].Time);
                }

            } else if (Type == (byte)CharacterInfoPage.Deaths) {
                message.Write(RecentDeathsPageCurrent);
                message.Write(RecentDeathsPageMax);

                var count = Math.Min(RecentDeaths.Count, ushort.MaxValue);
                message.Write((ushort)count);
                for (var i = 0; i < count; ++i) {
                    message.Write(RecentDeaths[i].Timestamp);
                    message.Write(RecentDeaths[i].Cause);
                }
            } else if (Type == (byte)CharacterInfoPage.Pvp) {
                message.Write(RecentPvpKillsPageCurrent);
                message.Write(RecentPvpKillsPageMax);

                var count = Math.Min(RecentPvpKills.Count, ushort.MaxValue);
                message.Write((ushort)count);
                for (var i = 0; i < count; ++i) {
                    message.Write(RecentPvpKills[i].Timestamp);
                    message.Write(RecentPvpKills[i].Description);
                    message.Write(RecentPvpKills[i].Status);
                }
            } else if (Type == (byte)CharacterInfoPage.Achiev) {
                message.Write(AchievementPoints);
                message.Write(SecretAchievementsMax);

                var count = Math.Min(UnlockedAchievements.Count, ushort.MaxValue);
                message.Write((ushort)count);
                for (var i = 0; i < count; ++i) {
                    var (Id, Timestamp, IsSecret, Name, Description, Grade) = UnlockedAchievements[i];
                    message.Write(Id);
                    message.Write(Timestamp);
                    message.Write(IsSecret);
                    if (IsSecret) {
                        message.Write(Name);
                        message.Write(Description);
                        message.Write(Grade);
                    }
                }
            } else if (Type == (byte)CharacterInfoPage.Items) {
                void AppendItems(List<(ushort id, uint amount)> items)
                {
                    var count = Math.Min(items.Count, ushort.MaxValue);
                    message.Write((ushort)count);
                    for (var i = 0; i < count; ++i) {
                        var (Id, Amount) = items[i];
                        message.Write(Id);
                        message.Write(Amount);
                    }
                }

                AppendItems(InventoryItems);
                AppendItems(StoreInboxItems);
                AppendItems(StashItems);
                AppendItems(DepotItems);
                AppendItems(InboxItems);
            } else if (Type == (byte)CharacterInfoPage.Outfits) {
                var count = Math.Min(Outfits.Count, ushort.MaxValue);
                message.Write((ushort)count);
                for (var i = 0; i < count; ++i) {
                    var (Id, Name, Addons, IsPremium, Unknown) = Outfits[i];
                    message.Write(Id);
                    message.Write(Name);
                    message.Write(Addons);
                    message.Write(IsPremium);
                    message.Write(Unknown);
                }
				
                if (count > 0) {
                    message.Write(HeadColor);
                    message.Write(TorsoColor);
                    message.Write(LegsColor);
                    message.Write(DetailColor);
                }
				
                count = Math.Min(Mounts.Count, ushort.MaxValue);
                message.Write((ushort)count);
                for (var i = 0; i < count; ++i) {
                    var (Id, Name, IsPremium, Unknown) = Mounts[i];
                    message.Write(Id);
                    message.Write(Name);
                    message.Write(IsPremium);
                    message.Write(Unknown);
                }
				
                if (count > 0) {
                    message.Write(MountHeadColor);
                    message.Write(MountTorsoColor);
                    message.Write(MountLegsColor);
                    message.Write(MountDetailColor);
                }
				
                count = Math.Min(Familiars.Count, ushort.MaxValue);
                message.Write((ushort)count);
                for (var i = 0; i < count; ++i) {
                    var (Id, Name, IsPremium, Unknown) = Familiars[i];
                    message.Write(Id);
                    message.Write(Name);
                    message.Write(IsPremium);
                    message.Write(Unknown);
				}
				
            } else if (Type == (byte)CharacterInfoPage.Store) {
                message.Write(RemainingStoreXpBoostTime);
                message.Write(RemainingDailyRewardXpBoostTime);
                var count = Math.Min(Blessings.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i) {
                    var (Name, Amount) = Blessings[i];
                    message.Write(Name);
                    message.Write(Amount);
                }
                message.Write(PermanentPreySlots);
                message.Write(PreyWildcards);
                message.Write(InstantRewardAccess);
                message.Write(CharmExpansion);
                message.Write(PurchasedHirelings);
                count = Math.Min(HirelingJobIds.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i)
                    message.Write(HirelingJobIds[i]);
					
                count = Math.Min(HirelingOutfitIds.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i)
                    message.Write(HirelingOutfitIds[i]);
				
                message.Write(PurchasedHouseItems);
            } else if (Type == (byte)CharacterInfoPage.Inspect) {
                var count = Math.Min(InspectionItems.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i) {
                    var (Name, Slot, Item, ImbuementIds, Details) = InspectionItems[i];

                    message.Write(Slot);
                    message.Write(Name);
                    message.Write(Item);

                    var size = Math.Min(ImbuementIds.Count, byte.MaxValue);
                    message.Write((byte)size);
                    for (var j = 0; j < size; ++j)
                        message.Write(ImbuementIds[j]);

                    size = Math.Min(Details.Count, byte.MaxValue);
                    message.Write((byte)size);
                    for (var j = 0; j < size; ++j) {
                        message.Write(Details[j].Name);
                        message.Write(Details[j].Description);
                    }
                }
                message.Write(PlayerName);
                if (Outfit is OutfitInstance) {
                    message.Write((OutfitInstance)Outfit);
                } else {
                    message.Write((ushort)0);
                    message.Write((ushort)Outfit.Id);
                }

                count = Math.Min(PlayerDetails.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var j = 0; j < count; ++j) {
                    message.Write(PlayerDetails[j].Name);
                    message.Write(PlayerDetails[j].Description);
                }
            } else if (Type == (byte)CharacterInfoPage.Badges) {
                message.Write(ShowAccountInformation);
                if (ShowAccountInformation) {
                    message.Write(IsOnline);
                    message.Write(IsPremium);
                    message.Write(LoyaltyTitle);
                    var count = Math.Min(Badges.Count, byte.MaxValue);
                    message.Write((byte)count);
                    for (var i = 0; i < count; ++i) {
                        var (id, name) = Badges[i];
                        message.Write(id);
                        message.Write(name);
                    }
                }
            } else if (Type == (byte)CharacterInfoPage.Titles) {
                message.Write(CurrentCharacterTitle);
                var count = Math.Min(Titles.Count, byte.MaxValue);
                message.Write((byte)count);
                for (var i = 0; i < count; ++i) {
                    var (id, name, description, permanent, unlocked) = Titles[i];
                    message.Write(id);
                    message.Write(name);
                    message.Write(description);
                    message.Write(permanent);
                    message.Write(unlocked);
                }
            }
        }
    }
}
