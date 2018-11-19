using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmBalanceSummaryViewModel
    {
        [JsonProperty(PropertyName = "totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty(PropertyName = "balances")]
        public ICollection<CmBalanceViewModel> Balances { get; set; }
    }
}
