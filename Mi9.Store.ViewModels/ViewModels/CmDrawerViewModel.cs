using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDrawerViewModel
    {
        [JsonProperty(PropertyName = "ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "drawer")]
        public byte Drawer { get; set; }

        [JsonProperty(PropertyName = "issuedDate")]
        public DateTime? IssuedDate { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "tranZNumber")]
        public int? TranZNumber { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public ICollection<CmDrawerTenderViewModel> Tenders { get; set; }
    }

    
}
