﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Turbo.Database.Entities.Room;

namespace Turbo.Database.Repositories.Room
{
    public interface IRoomModelRepository : IBaseRepository<RoomModelEntity>
    {
        Task<RoomModelEntity> FindByNameAsync(string ticket);
        Task<List<RoomModelEntity>> FindAllAsync();
    }
}