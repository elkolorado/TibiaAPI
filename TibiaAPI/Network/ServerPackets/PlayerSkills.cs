﻿using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ServerPackets
{
    public class PlayerSkills : ServerPacket
    {
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) AxeFighting { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) ClubFighting { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) DistanceFighting { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) Fishing { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) FistFighting { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) Magic { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) Shielding { get; set; }
        public (ushort Level, ushort Base, ushort Loyalty, ushort Progress) SwordFighting { get; set; }

        public (ushort Level, ushort Base) CriticalHitChance { get; set; }
        public (ushort Level, ushort Base) CriticalHitDamage { get; set; }
        public (ushort Level, ushort Base) LifeLeechAmount { get; set; }
        public (ushort Level, ushort Base) LifeLeechChance { get; set; }
        public (ushort Level, ushort Base) ManaLeechAmount { get; set; }
        public (ushort Level, ushort Base) ManaLeechChance { get; set; }
        public (ushort Level, ushort Base) FatalAmount { get; set; }
        public (ushort Level, ushort Base) DodgeAmount { get; set; }
        public (ushort Level, ushort Base) MomentumAmount { get; set; }

        public uint BonusCapacity { get; set; }
        public uint MaxCapacity { get; set; }

        public PlayerSkills(Client client)
        {
            Client = client;
            PacketType = ServerPacketType.PlayerSkills;
        }

        public override void ParseFromNetworkMessage(NetworkMessage message)
        {
            Magic = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            FistFighting = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            ClubFighting = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            SwordFighting = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            AxeFighting = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            DistanceFighting = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            Shielding = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());
            Fishing = (message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16(), message.ReadUInt16());

            CriticalHitChance = (message.ReadUInt16(), message.ReadUInt16());
            CriticalHitDamage = (message.ReadUInt16(), message.ReadUInt16());
            LifeLeechChance = (message.ReadUInt16(), message.ReadUInt16());
            LifeLeechAmount = (message.ReadUInt16(), message.ReadUInt16());
            ManaLeechChance = (message.ReadUInt16(), message.ReadUInt16());
            ManaLeechAmount = (message.ReadUInt16(), message.ReadUInt16());

            FatalAmount = (message.ReadUInt16(), message.ReadUInt16());
            DodgeAmount = (message.ReadUInt16(), message.ReadUInt16());
            MomentumAmount = (message.ReadUInt16(), message.ReadUInt16());

            MaxCapacity = message.ReadUInt32();
            BonusCapacity = message.ReadUInt32();
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ServerPacketType.PlayerSkills);
			
            message.Write(Magic.Level);
            message.Write(Magic.Base);

            message.Write(Magic.Loyalty);
            message.Write(Magic.Progress);

            message.Write(FistFighting.Level);
            message.Write(FistFighting.Base);

            message.Write(FistFighting.Loyalty);
            message.Write(FistFighting.Progress);

            message.Write(ClubFighting.Level);
            message.Write(ClubFighting.Base);

            message.Write(ClubFighting.Loyalty);
            message.Write(ClubFighting.Progress);

            message.Write(SwordFighting.Level);
            message.Write(SwordFighting.Base);

            message.Write(SwordFighting.Loyalty);
            message.Write(SwordFighting.Progress);

            message.Write(AxeFighting.Level);
            message.Write(AxeFighting.Base);

            message.Write(AxeFighting.Loyalty);
            message.Write(AxeFighting.Progress);

            message.Write(DistanceFighting.Level);
            message.Write(DistanceFighting.Base);

            message.Write(DistanceFighting.Loyalty);
            message.Write(DistanceFighting.Progress);

            message.Write(Shielding.Level);
            message.Write(Shielding.Base);

            message.Write(Shielding.Loyalty);
            message.Write(Shielding.Progress);

            message.Write(Fishing.Level);
            message.Write(Fishing.Base);

            message.Write(Fishing.Loyalty);
            message.Write(Fishing.Progress);

            message.Write(CriticalHitChance.Level);
            message.Write(CriticalHitChance.Base);

            message.Write(CriticalHitDamage.Level);
            message.Write(CriticalHitDamage.Base);

            message.Write(LifeLeechChance.Level);
            message.Write(LifeLeechChance.Base);

            message.Write(LifeLeechAmount.Level);
            message.Write(LifeLeechAmount.Base);

            message.Write(ManaLeechChance.Level);
            message.Write(ManaLeechChance.Base);

            message.Write(ManaLeechAmount.Level);
            message.Write(ManaLeechAmount.Base);

            message.Write(FatalAmount.Level);
            message.Write(FatalAmount.Base);
            
            message.Write(DodgeAmount.Level);
            message.Write(DodgeAmount.Base);
            
            message.Write(MomentumAmount.Level);
            message.Write(MomentumAmount.Base);

            message.Write(MaxCapacity);
            message.Write(BonusCapacity);
        }
    }
}
