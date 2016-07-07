using System;
using Nop.Core.Plugins;
using Septa.PgNopIntegration.Plugin.Data;
using Septa.PgNopIntegration.Plugin.Domain;
using Nop.Core.Data;

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

        public override void Install()
        {
            _pgProductIntegrationContext.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _pgProductIntegrationContext.Uninstall();
            base.Uninstall();
        }
    }
}
