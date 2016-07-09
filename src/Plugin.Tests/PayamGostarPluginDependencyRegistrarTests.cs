using Autofac;
using Moq;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Septa.PayamGostar.ServiceLayer.ServiceType.Api;
using Septa.PgNopIntegration.Plugin.PayamGostarService;
using Xunit;

namespace Septa.PgNopIntegration.Plugin.Tests
{
    public class PayamGostarPluginDependencyRegistrarTests
    {
        [Fact]
        public void RegistrarOrderIsZero()
        {
            var registrar = new PayamGostarPluginDependencyRegistrar();

            Assert.Equal(0, registrar.Order);
        }

        [Fact]
        public void IProductSyncServiceIsRegisteredInBuilder()
        {
            var containerBuilder = new ContainerBuilder();
            var typeFinder = Mock.Of<ITypeFinder>();
            var nopConfig = Mock.Of<NopConfig>();
            var registrar = new PayamGostarPluginDependencyRegistrar();

            registrar.Register(containerBuilder, typeFinder, nopConfig);
            var container = containerBuilder.Build(Autofac.Builder.ContainerBuildOptions.None);
            
            Assert.IsType<ProductSyncService>(container.Resolve<IProductSyncService>());
        }
    }
}
