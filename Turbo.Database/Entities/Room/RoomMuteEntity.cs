﻿using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Turbo.Database.Entities.Players;
using System.ComponentModel.DataAnnotations;
using Turbo.Database.Entities.Catalog;

namespace Turbo.Database.Entities.Room
{
    [Table("room_mutes"), Index(nameof(RoomEntityId), nameof(PlayerEntityId), IsUnique = true)]
    public class RoomMuteEntity : Entity
    {
        [Column("room_id"), Required]
        public int RoomEntityId { get; set; }

        [Column("player_id"), Required]
        public int PlayerEntityId { get; set; }

        [Column("date_expires"), Required]
        public DateTime DateExpires { get; set; }

        [ForeignKey(nameof(RoomEntityId))]
        public RoomEntity RoomEntity { get; set; }

        [ForeignKey(nameof(PlayerEntityId))]
        public PlayerEntity PlayerEntity { get; set; }
    }
}
