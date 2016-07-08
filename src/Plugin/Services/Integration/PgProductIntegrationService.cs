using Nop.Services.Catalog;
using Septa.PgNopIntegration.Plugin.Common.DTO;
using Septa.PgNopIntegration.Plugin.Services.Catalog;
using Septa.PgNopIntegration.Plugin.Services.Helpers;
using System;

namespace Septa.PgNopIntegration.Plugin.Services.Integration
{
    /// <summary>
    /// PgProduct Integration Service interface
    /// </summary>
    public partial class PgProductIntegrationService : IPgProductIntegrationService
    {
        # region Fields

        private readonly IPgProductWebApiHelper<PgProductMetaDataDto> _pgProductWebApiHelper;
        private readonly IProductService _productService;
        private readonly IPgProductMetaDataService _pgProductMetaDataService;
        private readonly string _url = "";

        # endregion

        # region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="productService">Product Service</param>
        /// /// <param name="pgProductMetaDataService">PgProduct MetaData Service</param>
        /// <param name="pgWebApiHelper">IPgProduct Web Api Helper</param>
        public PgProductIntegrationService(IProductService productService, IPgProductMetaDataService pgProductMetaDataService, IPgProductWebApiHelper<PgProductMetaDataDto> pgWebApiHelper)
        {
            this._productService = productService;
            this._pgProductMetaDataService = pgProductMetaDataService;
            this._pgProductWebApiHelper = pgWebApiHelper;
            _pgProductWebApiHelper.Url = _url;
        }

        # endregion

        # region Methods

        /// <summary>
        /// starts product synchronization from PayamGostar
        /// </summary>
        public virtual void SyncFromPayamGostar()
        {
            try
            {
                var productList = _pgProductWebApiHelper.GetAllProductsByLasSyncDate(DateTime.Now);
                if (productList != null)
                {
                    // TODO Something...
                }
            }
            catch (Exception ex)
            {
                // TODO some log insertion...
            }
        }

        # endregion
    }
}
