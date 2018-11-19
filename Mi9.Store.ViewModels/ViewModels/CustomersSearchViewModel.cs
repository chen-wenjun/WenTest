using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CustomersSearchViewModel
    {
        [JsonProperty(PropertyName = "customers")]
        public IEnumerable<CustomerViewModel> Customers { get; set; }

        [JsonProperty(PropertyName = "count")]
        public long Count { get; set; }
    }
}
