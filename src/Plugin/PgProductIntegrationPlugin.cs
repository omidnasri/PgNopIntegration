using System;
using Septa.PgNopIntegration.Plugin.Data;
using Septa.PgNopIntegration.Plugin.Domain;
using Nop.Core.Data;
using Nop.Core.Plugins;

namespace Septa.PgNopIntegration.Plugin
{
    public class PgProductIntegrationPlugin : BasePlugin
    {
        private readonly PgProductIntegrationObjectContext _pgProductIntegrationContext;
        private readonly IRepository<PgProductMetaData> _pgProductMetaDataRepository;

        public PgProductIntegrationPlugin(PgProductIntegrationObjectContext pgProductIntegrationContext, IRepository<PgProductMetaData> pgProductMetaDataRepository)
        {
            this._pgProductIntegrationContext = pgProductIntegrationContext;
            this._pgProductMetaDataRepository = pgProductMetaDataRepository;
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            _pgProductIntegrationContext.Install();
            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            _pgProductIntegrationContext.Uninstall();
            base.Uninstall();
        }
    }
}
