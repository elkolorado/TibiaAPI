﻿using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ClientPackets
{
    public class CyclopediaBosstiary : ClientPacket
    {

        public CyclopediaBosstiary(Client client)
        {
            Client = client;
            PacketType = ClientPacketType.CyclopediaBosstiary;
        }

        public override void ParseFromNetworkMessage(NetworkMessage message)
        {
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ClientPacketType.CyclopediaBosstiary);
        }
    }
}
