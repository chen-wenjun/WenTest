using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SafeBalanceViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public Int16 Id { get; set; }

        [JsonProperty(PropertyName = "balance")]
        public decimal TenderAmount { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int TenderCount { get; set; }
    }
}
