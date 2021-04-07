﻿using Microsoft.Extensions.Logging;
using System;
using Turbo.Core.Game.Players;
using Turbo.Core.Game.Rooms.Managers;
using Turbo.Core.Game.Rooms.Mapping;
using Turbo.Core.Game.Rooms.Utils;
using Turbo.Core.Networking.Game.Clients;
using Turbo.Core.Packets.Messages;

namespace Turbo.Core.Game.Rooms
{
    public interface IRoom : IAsyncInitialisable, IAsyncDisposable, ICyclable
    {
        public ILogger<IRoom> Logger { get; }
        public IRoomManager RoomManager { get; }
        public IRoomDetails RoomDetails { get; }
        public IRoomCycleManager RoomCycleManager { get; }
        public IRoomSecurityManager RoomSecurityManager { get; }
        public IRoomFurnitureManager RoomFurnitureManager { get; }
        public IRoomUserManager RoomUserManager { get; }

        public IRoomModel RoomModel { get; }
        public IRoomMap RoomMap { get; }

        public bool IsInitialized { get; }
        public bool IsDisposed { get; }
        public bool IsDisposing { get; }

        public void TryDispose();
        public void CancelDispose();

        public void EnterRoom(IPlayer player, IPoint location = null);
        public void AddObserver(ISession session);
        public void RemoveObserver(ISession session);
        public void SendComposer(IComposer composer);

        public int Id { get; }
    }
}
