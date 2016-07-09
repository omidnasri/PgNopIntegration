using Septa.PayamGostar.ServiceLayer.ServiceType.Api;
using System;
using Septa.PayamGostar.ServiceLayer.Contract.DataContracts;

namespace Septa.PgNopIntegration.Plugin.PayamGostarService
{
    /// <summary>
    /// ProductSyncService channel
    /// </summary>
    public class ProductSyncService : IProductSyncService
    {
        /// <summary>
        /// Gets product changes
        /// </summary>
        /// <param name="syncDate">last sync date</param>
        /// <returns>Product changes</returns>
        public ProductChanges GetProductChangesSince(DateTime syncDate)
        {
            return new ProductChanges();
        }
    }
}
