namespace Mi9.Store.ViewModels.ViewModels
{
    using Newtonsoft.Json;

    public class CustomerProjectsViewModel
    {
        [JsonProperty(PropertyName = "projectId")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "materials")]
        public string Materials { get; set; }
    }
}