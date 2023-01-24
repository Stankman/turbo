﻿using System;
using System.Collections.Generic;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Rooms.Object.Logic.Avatar;
using Turbo.Rooms.Object.Logic.Furniture;
using Turbo.Rooms.Object.Logic.Furniture.Wired.Triggers;
using Turbo.Rooms.Object.Logic.Furniture.Wired.Conditions;
using Turbo.Core.Game.Furniture.Data;

namespace Turbo.Rooms.Object.Logic
{
    public class RoomObjectLogicFactory : IRoomObjectLogicFactory
    {
        public IDictionary<string, Type> Logics { get; private set; }


        public RoomObjectLogicFactory()
        {
            Logics = new Dictionary<string, Type>();

            Logics.Add(RoomObjectLogicType.User, typeof(AvatarLogic));
            Logics.Add(RoomObjectLogicType.Pet, typeof(PetLogic));
            Logics.Add(RoomObjectLogicType.Bot, typeof(BotLogic));
            Logics.Add(RoomObjectLogicType.RentableBot, typeof(RentableBotLogic));

            Logics.Add(RoomObjectLogicType.FurnitureDefaultFloor, typeof(FurnitureFloorLogic));
            Logics.Add(RoomObjectLogicType.FurnitureDefaultWall, typeof(FurnitureWallLogic));
            Logics.Add(RoomObjectLogicType.FurnitureStackHelper, typeof(FurnitureStackHelperLogic));
            Logics.Add(RoomObjectLogicType.FurnitureRoller, typeof(FurnitureRollerLogic));
            Logics.Add(RoomObjectLogicType.FurnitureGate, typeof(FurnitureGateLogic));
            Logics.Add(RoomObjectLogicType.FurnitureTeleport, typeof(FurnitureTeleportLogic));
            Logics.Add(RoomObjectLogicType.FurnitureDice, typeof(FurnitureDiceLogic));

            Logics.Add(RoomObjectLogicType.FurnitureWiredTriggerEnterRoom, typeof(FurnitureWiredTriggerEnterRoomLogic));
            Logics.Add(RoomObjectLogicType.FurnitureWiredTriggerWalksOnFurni, typeof(FurnitureWiredTriggerWalksOnFurni));
            Logics.Add(RoomObjectLogicType.FurnitureWiredTriggerWalksOffFurni, typeof(FurnitureWiredTriggerWalksOffFurni));
            Logics.Add(RoomObjectLogicType.FurnitureWiredTriggerStateChanged, typeof(FurnitureWiredTriggerStateChangeLogic));

            #region Wired Conditions
            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionActorIsWearingBadge, typeof(FurnitureWiredConditionActorIsWearingBadge));
            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionNotActorWearsBadge, typeof(FurnitureWiredConditionNotActorWearsBadge));

            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionHasStackedFurnis, typeof(FurnitureWiredConditionHasStackedFurnis));
            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionNotHasStackedFurnis, typeof(FurnitureWiredConditionNotHasStackedFurnis));

            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionTriggererOnFurni, typeof(FurnitureWiredConditionTriggererOnFurni));
            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionNotTriggererOnFurni, typeof(FurnitureWiredConditionNotTriggererOnFurni));

            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionFurniHasAvatars, typeof(FurnitureWiredConditionFurniHasAvatars));
            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionNotFurniHasAvatars, typeof(FurnitureWiredConditionNotFurniHasAvatars));

            Logics.Add(RoomObjectLogicType.FurnitrueWiredConditionUserCountIn, typeof(FurnitureWiredConditionUserCountIn));
            Logics.Add(RoomObjectLogicType.FurnitureWiredConditionNotUserCountIn, typeof(FurnitureWiredConditionNotUserCountIn));

            #endregion
        }

        public IRoomObjectLogic Create(string type)
        {
            var logicType = GetLogicType(type);

            if (logicType == null) return null;

            return (IRoomObjectLogic)Activator.CreateInstance(logicType);
        }

        public Type GetLogicType(string type)
        {
            if (!Logics.ContainsKey(type)) return null;

            return Logics[type];
        }

        public StuffDataKey GetStuffDataKeyForFurnitureType(string type)
        {
            if (!Logics.ContainsKey(type)) return StuffDataKey.LegacyKey;

            if (Logics[type].IsAssignableFrom(typeof(FurnitureLogicBase)))
            {
                //var logicType = typeof(FurnitureLogicBase) Logics[type];
            }

            return StuffDataKey.LegacyKey;
        }
    }
}
