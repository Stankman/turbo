using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Core.Game.Catalog
{
    public interface ICatalogPage
    {
        public ICatalogPage Parent { get; }
        public IDictionary<int, ICatalogPage> Children { get; }
        public IDictionary<int, ICatalogOffer> Offers { get; }
        public IList<int> OfferIds { get; }
        public IList<string> ImageDatas { get; }
        public IList<string> TextDatas { get; }

        public void SetParent(ICatalogPage catalogPage);
        public void AddChild(ICatalogPage catalogPage);
        public void AddOffer(ICatalogOffer catalogItem);
        public void CacheOfferIds();

        public int Id { get; }
        public int ParentId { get; }
        public int Icon { get; }
        public string Name { get; }
        public string Localization { get; }
        public string Layout { get; }
        public bool Visible { get; }
    }
}