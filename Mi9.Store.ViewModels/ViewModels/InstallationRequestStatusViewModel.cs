using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallationRequestStatusViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}