﻿using Turbo.Core.Packets.Messages;

namespace Turbo.Packets.Outgoing.Handshake
{
    public record SleepMessage : IComposer
    {
        public int UserId { get; init; }
        public bool Sleeping { get; init; }
    }
}
