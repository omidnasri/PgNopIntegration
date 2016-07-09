using Nop.Core.Infrastructure.DependencyManagement;
using System;
using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Septa.PayamGostar.ServiceLayer.ServiceType.Api;
using Septa.PgNopIntegration.Plugin.PayamGostarService;

namespace Septa.PgNopIntegration.Plugin
{
    public class PayamGostarPluginDependencyRegistrar : IDependencyRegistrar
    {
        public int Order
        {
            get
            {
                return 0;
            }
        }

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<ProductSyncService>().As<IProductSyncService>();
        }
    }
}
