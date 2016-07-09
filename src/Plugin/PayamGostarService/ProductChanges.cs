using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Septa.PayamGostar.ServiceLayer.Contract.DataContracts
{
    /// <summary>
    /// Represents changes in Payam Gostar products.
    /// Stores deleted, edited and new products.
    /// </summary>
    [DataContract]
    public class ProductChanges
    {
        /// <summary>
        /// Product codes that are no longer in Payam Gostar
        /// </summary>
        public IEnumerable<string> DeletedProductCodes  { get; set; }

        /// <summary>
        /// Products that are edited since last sync
        /// </summary>
        public IEnumerable<Product> EditedProducts { get; set; }

        /// <summary>
        /// Products that are inserted since last sync
        /// </summary>
        public IEnumerable<Product> NewProducts { get; set; }
    }
}
