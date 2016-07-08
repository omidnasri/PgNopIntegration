using System;

namespace Septa.PgNopIntegration.Plugin.Services.Integration
{
    /// <summary>
    /// PgProduct Integration service interface
    /// </summary>
    public partial interface IPgProductIntegrationService
    {
        /// <summary>
        /// starts product synchronization from PayamGostar
        /// </summary>
        void SyncFromPayamGostar();
    }
}
