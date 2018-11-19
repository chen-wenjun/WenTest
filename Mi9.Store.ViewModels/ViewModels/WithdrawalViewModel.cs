using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class WithdrawalViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int WithdrawalId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string DocumentType { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "cashier")]
        public CashierViewModel Cashier { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public short? PartialNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "balanceStatus")]
        public string BalanceStatus { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "denominations")]
        public TenderTypeDenominationsViewModel[] Denominations { get; set; }

        public bool ShouldSerializePartialNumber()
        {
            return PartialNumber.HasValue;
        }
    }
}