using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CompetitorSearchViewModel
    {       

        [JsonProperty(PropertyName = "competitors")]
        public IEnumerable<CompetitorViewModel> Competitors { get; set; }

        [JsonProperty(PropertyName = "count")]
        public long Count { get; set; }
    }
}
