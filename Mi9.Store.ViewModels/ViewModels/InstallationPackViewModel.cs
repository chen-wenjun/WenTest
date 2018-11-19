using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallationPackViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("storeNumber")]
        public short StoreNumber { get; set; }

        [JsonProperty("name")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isTechnicalVisitRequired")]
        public bool IsTechnicalVisitRequired { get; set; }

        [JsonProperty("department")]
        public DepartmentViewModel Department { get; set; }

        [JsonProperty("services")]
        public InstallationPackDetailViewModel[] Details { get; set; }
    }
}