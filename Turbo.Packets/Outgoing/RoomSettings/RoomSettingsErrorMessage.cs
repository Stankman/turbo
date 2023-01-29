using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Rooms.Constants;
using Turbo.Core.Packets.Messages;

namespace Turbo.Packets.Outgoing.RoomSettings
{
    public record RoomSettingsErrorMessage : IComposer
    {
        public int RoomId { get; init; }
        public RoomSettingsErrorType ErrorCode { get; init; }
    }
}