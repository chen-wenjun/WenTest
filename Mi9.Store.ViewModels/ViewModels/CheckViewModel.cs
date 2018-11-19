
using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CheckViewModel
    {
        [JsonProperty("depositDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime DepositDate { get; set; }

        [JsonProperty("expireDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime ExpireDate { get; set; }

        [JsonProperty("transactionDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime TransactionDate { get; set; }

        [JsonProperty("registerId")]
        public short RegisterId { get; set; }

        [JsonProperty("transactionNumber")]
        public int TransactionNumber { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("authNumber")]
        public string AuthNumber { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("checkNumber")]
        public string CheckNumber { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}