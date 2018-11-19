using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDrawersViewModel
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

        public ICollection<CmDrawerTendersViewModel> Tenders { get; set; }
    }

    public class CmDrawerTendersViewModel
    {
        [JsonProperty(PropertyName = "tenderId")]
        public int TenderId { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "totalPickedUpAmount")]
        public decimal TotalPickedUpAmount { get; set; }

        [JsonProperty(PropertyName = "totalPickedUpCount")]
        public int TotalPickedUpCount { get; set; }

        [JsonProperty(PropertyName = "totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; set; }
    }
}
