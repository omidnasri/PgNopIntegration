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


namespace Septa.PgNopIntegration.Plugin.Infrastructure
{
    public class DependencyRegister : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_pg_product_integration";

        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //data context
            this.RegisterPluginDataContext<PgProductIntegrationObjectContext>(builder, CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<PgProductMetaData>>()
                .As<IRepository<PgProductMetaData>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
