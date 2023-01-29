using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;

namespace Turbo.Packets.Incoming.RoomSettings
{
    public record GetCustomRoomFilterMessage : IMessageEvent
    {
        public int RoomId { get; init; }
    }
}