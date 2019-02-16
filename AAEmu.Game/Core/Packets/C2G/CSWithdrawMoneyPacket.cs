﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Items;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSWithdrawMoneyPacket : GamePacket
    {
        public CSWithdrawMoneyPacket() : base(0x048, 1) // TODO 1.0 opcode: 0x046
        {
        }

        public override void Read(PacketStream stream)
        {
            var amount = stream.ReadInt32();
            var aapoint = stream.ReadInt32();

            _log.Debug("WithdrawMoney: amount -> {0}, aa_point -> {1}", amount, aapoint);

            Connection.ActiveChar.ChangeMoney(SlotType.Inventory, amount);
        }
    }
}
