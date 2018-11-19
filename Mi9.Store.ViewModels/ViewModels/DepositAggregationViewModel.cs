using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DepositAggregationViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int AggregationId { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "cashier")]
        public CashierViewModel Cashier { get; set; }

        [JsonProperty(PropertyName = "carrier")]
        public TransportCompanyViewModel Carrier { get; set; }

        [JsonProperty(PropertyName = "tender")]
        public TenderViewModel Tender { get; set; }

        [JsonProperty(PropertyName = "tenderType")]
        public TenderTypeViewModel TenderType { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string AmountError { get; set; }
    }
}