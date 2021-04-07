﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Turbo.Database.Entities.Room;

namespace Turbo.Database.Repositories.Room
{
    public interface IRoomRightRepository : IBaseRepository<RoomRightEntity>
    {
        public Task<List<RoomRightEntity>> FindAllByRoomIdAsync(int roomId);
    }
}