
namespace Mi9.Store.ViewModels.ViewModels
{
    public static class InstallationRequestFeedbackStatuses
    {
        private static readonly InstallationRequestFeedbackStatusViewModel[] _allStatuses = new[]
            {
                new InstallationRequestFeedbackStatusViewModel { Id = 1, Name = "Positive", DatabaseId = "p" },
                new InstallationRequestFeedbackStatusViewModel { Id = 2, Name = "Negative", DatabaseId = "r" },
                new InstallationRequestFeedbackStatusViewModel { Id = 3, Name = "Neutral", DatabaseId = "n" },
            };

        public static InstallationRequestFeedbackStatusViewModel[] AllStatuses 
        {
            get
            {
                return _allStatuses;
            }
        }
    }
}