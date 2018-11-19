using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class EJournalItemViewModel
    {
        [JsonProperty("transactionId")]
        public int TransactionId { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("time")]
        public TimeSpan TranTime { get; set; }

        [JsonProperty("registerId")]
        public short RegisterId { get; set; }

        [JsonProperty("cashierId")]
        public int CashierId { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}