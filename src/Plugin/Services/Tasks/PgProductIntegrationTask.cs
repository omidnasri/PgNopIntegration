using System;
using Nop.Services.Tasks;
using Septa.PgNopIntegration.Plugin.Services.Integration;

namespace Septa.PgNopIntegration.Plugin.Services.Tasks
{
    /// <summary>
    /// Represents a task for integrating products from PayamGostar 
    /// </summary>
    public partial class PgProductIntegrationTask : ITask
    {
        private readonly IPgProductIntegrationService _pgProductIntegrationServiec;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pgProductIntegrationServiec">PgProduct Integration Service</param>
        public PgProductIntegrationTask(IPgProductIntegrationService pgProductIntegrationServiec)
        {
            this._pgProductIntegrationServiec = pgProductIntegrationServiec;
        }

        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            _pgProductIntegrationServiec.SyncFromPayamGostar();
        }
    }
}
