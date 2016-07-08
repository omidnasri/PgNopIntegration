using System;
using System.Collections.Generic;
using Septa.PgNopIntegration.Plugin.Domain;
using Nop.Core;

namespace Septa.PgNopIntegration.Plugin.Services.Catalog
{
    /// <summary>
    /// PgProduct Metadata service interface
    /// </summary>
    public partial interface IPgProductMetaDataService
    {
        /// <summary>
        /// Deletes a PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaData">PgProduct MetaData</param>
        void DeletePgProductMetaData(PgProductMetaData pgProductMetaData);

        /// <summary>
        /// Gets all PgProduct MetaData
        /// </summary>
        /// <returns>PgProduct MetaData</returns>
        IPagedList<PgProductMetaData> GetAllPgProductMetaData(int pageIndex = 0, int pageSize = int.MaxValue);

        /// <summary>
        /// Gets PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaDataId">PgProduct MetaData identifier</param>
        /// <returns>PgProduct MetaData</returns>
        PgProductMetaData GetPgProductMetaDataById(int pgProductMetaDataId);

        /// <summary>
        /// Inserts a PgProduct MetaData
        /// </summary>
        /// <param name="taxRate">PgProduct MetaData</param>
        void InsertPgProductMetaData(PgProductMetaData pgProductMetaData);

        /// <summary>
        /// Updates the PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaData">PgProduct MetaData</param>
        void UpdatePgProductMetaData(PgProductMetaData pgProductMetaData);
    }
}
