using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmStoreViewModel
    {
        [JsonProperty(PropertyName = "number")]
        public short StoreNumber { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string StoreName { get; set; }
    }
}
