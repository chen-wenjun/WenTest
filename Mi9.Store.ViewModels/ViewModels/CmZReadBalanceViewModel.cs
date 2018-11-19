using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmZReadBalanceViewModel
    {
        [JsonProperty(PropertyName = "balancingReason")]
        public string AdjustReason { get; set; }

        [JsonProperty(PropertyName = "ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "drawers")]
        public ICollection<CmDrawerBalancingViewModel> ValidatedDrawers { get; set; }
    }

    public class CmDrawerBalancingViewModel
    {
        [JsonProperty(PropertyName = "drawer")]
        public byte DrawerId { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "zRead")]
        public int? ZReadTranNumber { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public virtual ICollection<CmDrawerTenderBalanceViewModel> TenderBalances { get; set; }
    }

    public class CmDrawerTenderBalanceViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int TenderId { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "tenderAmount")]
        public decimal TenderAmount { get; set; }

        [JsonProperty(PropertyName = "tenderCount")]
        public int TenderCount { get; set; }
    }
}
