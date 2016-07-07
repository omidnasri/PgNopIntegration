using Nop.Core;
using System;

namespace Septa.PgNopIntegration.Plugin.Domain
{
    /// <summary>
    /// Represents a Payam Gostar ProductMetaData
    /// </summary>
    public class PgProductMetaData : BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the nopCommerce product identifier
        /// </summary>
        public int NopProductCode { get; set; }
        /// <summary>
        /// Gets or sets the Payam Gostar Product metaData code
        /// </summary>
        public int PgProductCode { get; set; }
        /// <summary>
        /// Gets or sets the last product sync with Payam Gostar
        /// </summary>
        public DateTime LastSyncDate { get; set; }
    }
}
