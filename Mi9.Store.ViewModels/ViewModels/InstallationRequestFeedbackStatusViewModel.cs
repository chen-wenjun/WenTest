using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   
    public class InstallationRequestFeedbackStatusViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public string DatabaseId { get; set; }

        public bool ShouldSerializeDatabaseId()
        {
            return false;
        }
    }
}