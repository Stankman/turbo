using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Game.Catalog.Constants;

namespace Turbo.Core.Game.Catalog
{
    public interface ICatalogFrontPageItem
    {
        public int Position { get; }
        public string Name { get; }
        public string PromoImage { get; }
        public FrontPageItemType Type { get; }
        public DateTime Expiration { get; }
    }
}