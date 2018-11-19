namespace Mi9.Store.ViewModels.ViewModels
{
    public static class InstallationWarrantyChargeKinds
    {
        private static readonly InstallationWarrantyChargeKindViewModel[] _all = {
                new InstallationWarrantyChargeKindViewModel { Id = 1, Name = "Store" },
                new InstallationWarrantyChargeKindViewModel { Id = 2, Name = "Installer" }
        };

        /// <summary>
        /// Gets all warranty types.
        /// </summary>
        public static InstallationWarrantyChargeKindViewModel[] All
        {
            get
            {
                return _all;
            }
        }
    }
}