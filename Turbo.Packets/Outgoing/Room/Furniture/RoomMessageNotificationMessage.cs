﻿using Turbo.Core.Packets.Messages;

namespace Turbo.Packets.Outgoing.Handshake
{
    public record RoomMessageNotificationMessage : IComposer
    {
        public int RoomId { get; init; }
        public string RoomName { get; init; }
        public string MessageCount { get; init; }
    }
}
