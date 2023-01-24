using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;

namespace Turbo.Packets.Outgoing.Catalog
{
    public record BonusRareInfoMessage : IComposer
    {
        public string ProductType { get; init; }
        public int ProductClassId { get; init; }
        public int TotalCoinsForBonus { get; init; }
        public int CoinsStillRequiredToBuy { get; init; }
    }
}