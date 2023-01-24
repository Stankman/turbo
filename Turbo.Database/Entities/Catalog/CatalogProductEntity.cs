using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Turbo.Core.Game.Furniture.Constants;
using Turbo.Database.Attributes;
using Turbo.Database.Entities.Furniture;

namespace Turbo.Database.Entities.Catalog
{
    [Table("catalog_products")]
    public class CatalogProductEntity : Entity
    {
        [Column("offer_id"), Required]
        public int CatalogOfferEntityId { get; set; }

        [Column("product_type"), Required]
        public string ProductType { get; set; }

        [Column("definition_id")]
        public int? FurnitureDefinitionEntityId { get; set; }

        [Column("extra_param")]
        public string? ExtraParam { get; set; }

        [Column("quantity"), Required, DefaultValueSql("1")]
        public int Quantity { get; set; }

        [Column("unique_size"), Required, DefaultValueSql("0")]
        public int UniqueSize { get; set; }

        [Column("unique_remaining"), Required, DefaultValueSql("0")]
        public int UniqueRemaining { get; set; }

        public CatalogOfferEntity Offer { get; set; }
        public FurnitureDefinitionEntity FurnitureDefinition { get; set; }
    }
}