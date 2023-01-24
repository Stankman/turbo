﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Turbo.Catalog.Factories;
using Turbo.Core.Game.Catalog;
using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Game.Players;
using Turbo.Database.Entities.Catalog;
using Turbo.Database.Repositories.Catalog;

namespace Turbo.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private readonly ILogger<ICatalogManager> _logger;
        private readonly ICatalogFactory _catalogFactory;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public IDictionary<string, ICatalog> Catalogs { get; private set; }

        public CatalogManager(
            ILogger<ICatalogManager> logger,
            ICatalogFactory catalogFactory,
            IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _catalogFactory = catalogFactory;
            _serviceScopeFactory = scopeFactory;

            Catalogs = new Dictionary<string, ICatalog>();
        }

        public async ValueTask InitAsync()
        {
            ICatalog normalCatalog = _catalogFactory.CreateCatalog(CatalogType.Normal);

            await normalCatalog.InitAsync();

            Catalogs.Add(normalCatalog.CatalogType, normalCatalog);
        }

        public ValueTask DisposeAsync()
        {
            return ValueTask.CompletedTask;
        }

        public ICatalogPage GetRootForPlayer(IPlayer player, string catalogType)
        {
            if (catalogType == null || !Catalogs.ContainsKey(catalogType)) return null;

            return Catalogs[catalogType]?.GetRootForPlayer(player);
        }
    }
}
