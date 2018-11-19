
namespace Mi9.Store.ViewModels.ViewModels
{
    using Newtonsoft.Json;

    public class InstallationAlertTypeViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}