using System;
using System.Collections.Generic;
using Septa.PgNopIntegration.Plugin.Domain;
using System.Linq;
using Nop.Core;
using Nop.Core.Data;

namespace Septa.PgNopIntegration.Plugin.Services.Catalog
{
    /// <summary>
    /// PgProduct MetaData service
    /// </summary>
    public partial class PgProductMetaDataService : IPgProductMetaDataService
    {

        #region Fields

        private readonly IRepository<PgProductMetaData> _pgProductMetaDataRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="taxRateRepository">PgProduct Metadata repository</param>
        public PgProductMetaDataService(IRepository<PgProductMetaData> taxRateRepository)
        {
            this._pgProductMetaDataRepository = taxRateRepository;
        }

        #endregion

        # region Methods

        /// <summary>
        /// Deletes a PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaData">PgProduct MetaData</param>
        public virtual void DeletePgProductMetaData(PgProductMetaData pgProductMetaData)
        {
            if (pgProductMetaData == null)
                throw new ArgumentNullException("pgProductMetaData");

            _pgProductMetaDataRepository.Delete(pgProductMetaData);
        }

        /// <summary>
        /// Gets all PgProduct MetaData
        /// </summary>
        /// <returns>PgProduct MetaData</returns>
        public virtual IPagedList<PgProductMetaData> GetAllPgProductMetaData(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = from t in _pgProductMetaDataRepository.Table
                        orderby t.LastSyncDate, t.Id descending
                        select t;
            var records = new PagedList<PgProductMetaData>(query, pageIndex, pageSize);
            return records;
        }

        /// <summary>
        /// Gets a PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaDataId">PgProduct MetaData identifier</param>
        /// <returns>PgProduct MetaData</returns>
        public virtual PgProductMetaData GetPgProductMetaDataById(int pgProductMetaDataId)
        {
            if (pgProductMetaDataId == 0)
                return null;

            return _pgProductMetaDataRepository.GetById(pgProductMetaDataId);
        }

        /// <summary>
        /// Inserts a PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaData">PgProduct MetaData</param>
        public virtual void InsertPgProductMetaData(PgProductMetaData pgProductMetaData)
        {
            if (pgProductMetaData == null)
                throw new ArgumentNullException("pgProductMetaData");

            _pgProductMetaDataRepository.Insert(pgProductMetaData);
        }

        /// <summary>
        /// Updates the PgProduct MetaData
        /// </summary>
        /// <param name="pgProductMetaData">PgProduct MetaData</param>
        public virtual void UpdatePgProductMetaData(PgProductMetaData pgProductMetaData)
        {
            if (pgProductMetaData == null)
                throw new ArgumentNullException("pgProductMetaData");

            _pgProductMetaDataRepository.Update(pgProductMetaData);
        }

        # endregion

    }
}
