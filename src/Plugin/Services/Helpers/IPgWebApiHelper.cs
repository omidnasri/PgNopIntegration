using System;
using System.Collections.Generic;

namespace Septa.PgNopIntegration.Plugin.Services.Helpers
{
    public partial interface IPgProductWebApiHelper <T>
    {
        # region Fields

        string Url { get; set; }

        # endregion

        # region Mthods

        IEnumerable<T> GetAllProductsByLasSyncDate(DateTime lastSyncDate);

        # endregion
    }
}
