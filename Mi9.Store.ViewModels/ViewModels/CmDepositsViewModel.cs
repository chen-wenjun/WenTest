using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDepositsViewModel
    {
        [JsonProperty(PropertyName = "totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty(PropertyName = "deposits")]
        public IEnumerable<CmDepositViewModel> Deposits { get; set; }
    }
}
