using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmBalanceViewModel
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public CmOwnerViewModel Owner { get; set; }

        [JsonProperty(PropertyName = "drawer")]
        public CmDrawerViewModel Drawer { get; set; }
    }
}
