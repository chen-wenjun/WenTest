using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CashManagementDashboardViewModel
    {
        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "tenderAmounts")]
        public ICollection<DashboardTenderAmountViewModel> TenderAmounts { get; set; }

        [JsonProperty(PropertyName = "cashBalances")]
        public ICollection<DashboardCashBalanceViewModel> CashBalances { get; set; }
    }

    public class DashboardTenderAmountViewModel 
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }

    public class DashboardCashBalanceViewModel
    {
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class CmDashboardViewModel
    {
        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty(PropertyName = "ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty(PropertyName = "drawers")]
        public ICollection<CmDashboardDrawerViewModel> Drawers { get; set; }
    }

    public class CmDashboardDrawerViewModel
    {

        [JsonProperty(PropertyName = "drawer")]
        public byte Drawer { get; set; }
        
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "tenderAmounts")]
        public ICollection<CmDashboardTenderAmountViewModel> TenderAmounts { get; set; }

        [JsonProperty(PropertyName = "cashBalances")]
        public ICollection<CmDashboardCashBalanceViewModel> CashBalances { get; set; }
    }

    public class CmDashboardTenderAmountViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }

    public class CmDashboardCashBalanceViewModel
    {
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}
