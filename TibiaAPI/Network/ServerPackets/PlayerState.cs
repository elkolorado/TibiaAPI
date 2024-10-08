﻿using OXGaming.TibiaAPI.Constants;

namespace OXGaming.TibiaAPI.Network.ServerPackets
{
    public class PlayerState : ServerPacket
    {
        public uint State { get; set; }

        public PlayerState(Client client)
        {
            Client = client;
            PacketType = ServerPacketType.PlayerState;
        }

        public override void ParseFromNetworkMessage(NetworkMessage message)
        {
            State = message.ReadUInt32();
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ServerPacketType.PlayerState);
            message.Write(State);
        }
    }
}
