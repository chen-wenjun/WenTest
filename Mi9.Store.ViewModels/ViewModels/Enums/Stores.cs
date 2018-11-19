using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
   public class StoreObj
    {
        [JsonProperty(PropertyName = "value")]
        public short Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class StoreCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<StoreObj> Items { get; set; }
    }
}
