using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallationWarrantyTypeViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}