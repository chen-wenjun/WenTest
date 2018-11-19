namespace Mi9.Store.ViewModels.ViewModels
{
    public static class InstallationWarrantyTypes
    {
        private static readonly InstallationWarrantyTypeViewModel[] _all = {
                new InstallationWarrantyTypeViewModel { Id = 1, Name = "Customer Satisfaction" },
                new InstallationWarrantyTypeViewModel { Id = 2, Name = "Installation Problem" },
            };

        public static InstallationWarrantyTypeViewModel[] All 
        {
            get
            {
                return _all;
            }
        }
    }
}