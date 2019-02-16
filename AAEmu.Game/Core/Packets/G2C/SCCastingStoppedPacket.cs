﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCCastingStoppedPacket : GamePacket
    {
        private readonly ushort _tlId;
        private readonly uint _duration;

        public SCCastingStoppedPacket(ushort tlId, uint duration) : base(0x0a4, 1) // 0x09e
        {
            _tlId = tlId;
            _duration = duration;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_tlId);
            stream.Write(_duration);
            return stream;
        }
    }
}
