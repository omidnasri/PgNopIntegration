using System;
using Autofac;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Web.Framework.Mvc;
using Septa.PgNopIntegration.Plugin.Domain;
using Nop.Core.Configuration;
using Septa.PgNopIntegration.Plugin.Data;
using Nop.Data;
using Nop.Core.Data;
using Autofac.Core;
using Septa.PgNopIntegration.Plugin.Services.Integration;
using Nop.Services.Catalog;
using Septa.PgNopIntegration.Plugin.Services.Helpers;
using Septa.PgNopIntegration.Plugin.Services.Catalog;

namespace Septa.PgNopIntegration.Plugin.Infrastructure
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    public class DependencyRegister : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_pg_product_integration";

        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //data context
            this.RegisterPluginDataContext<PgProductIntegrationObjectContext>(builder, CONTEXT_NAME);

            builder.RegisterType<PgProductIntegrationService>().As<IPgProductIntegrationService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<PgProductMetaDataService>().As<IPgProductMetaDataService>().InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(PgProductWebApiHelper<>)).As(typeof(IPgProductWebApiHelper<>)).InstancePerDependency();

            //override required repository with our custom context
            builder.RegisterType<EfRepository<PgProductMetaData>>()
                .As<IRepository<PgProductMetaData>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order
        {
            get { return 1; }
        }
    }
}
