namespace Mi9.Store.ViewModels.ViewModels
{
    /// <summary>
    /// The installation request print container.
    /// </summary>
    public class InstallationRequestPrintContainerViewModel 
    {
        /// <summary>
        /// The installation request.
        /// </summary>
        public InstallationRequestViewModel Request { get; set; }

        /// <summary>
        /// The purchase order.
        /// </summary>
        public OrderViewDataTransferObject Order { get; set; }

        /// <summary>
        /// The current store.
        /// </summary>
        public StoreViewModel CurrentStore { get; set; }
    }
}