﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Game.Players;

namespace Turbo.Core.Game.Navigator
{
    public interface INavigatorManager : IAsyncInitialisable, IAsyncDisposable
    {
        public int GetPendingRoomId(int userId);
        public void SetPendingRoomId(int userId, int roomId);
        public void ClearPendingRoomId(int userId);
        public Task GetGuestRoomMessage(IPlayer player, int roomId, bool enterRoom = false, bool isRoomForward = false);
        public Task EnterRoom(IPlayer player, int roomId, string password = null, bool skipState = false);
        public Task ContinueEnteringRoom(IPlayer player);
    }
}