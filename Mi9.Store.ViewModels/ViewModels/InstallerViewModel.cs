using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallerViewModel : InstallerViewModelBase
    {
        [JsonProperty(PropertyName = "pendingInstalls")]
        public int PendingInstalls { get; set; }

        [JsonProperty(PropertyName = "totalInstalls")]
        public int TotalInstalls { get; set; }
    }
}