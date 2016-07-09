using Septa.PayamGostar.ServiceLayer.Contract.DataContracts;
using System;
using System.ServiceModel;

namespace Septa.PayamGostar.ServiceLayer.ServiceType.Api
{
    /// <summary>
    /// Service contract for Payam Gostar service which handles syncing products from and to nop commerce
    /// </summary>
    [ServiceContract]
    public interface IProductSyncService
    {
        /// <summary>
        /// Returns changes in Payam Gostar products since last sync
        /// </summary>
        /// <param name="syncDate">Last sync date</param>
        /// <returns>Product changes</returns>
        [OperationContract]
        ProductChanges GetProductChangesSince(DateTime syncDate);
    }
}
