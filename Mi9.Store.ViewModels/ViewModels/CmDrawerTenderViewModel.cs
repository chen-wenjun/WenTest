using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDrawerTenderViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "pickupsAmount")]
        public decimal PickupsAmount { get; set; }

        [JsonProperty(PropertyName = "pickupsCount")]
        public int PickupsCount { get; set; }

        [JsonProperty(PropertyName = "actualAmount")]
        public decimal ActualAmount { get; set; }

        [JsonProperty(PropertyName = "actualCount")]
        public int ActualCount { get; set; }

        //[JsonProperty(PropertyName = "overShortAmount")]
        //public decimal OverShortAmount { get; set; }

        //[JsonProperty(PropertyName = "overShortCount")]
        //public int OverShortCount { get; set; }

        [JsonProperty(PropertyName = "zReadsAmount")]
        public decimal ZReadsAmount { get; set; }
        
        [JsonProperty(PropertyName = "zReadsCount")]
        public int ZReadsCount { get; set; }

        [JsonProperty(PropertyName = "loansAmount")]
        public int LoansAmount { get; set; }

        [JsonProperty(PropertyName = "loansCount")]
        public int LoansCount { get; set; }


        //control JSon serialization

        [JsonIgnore]
        public bool IgnoreLoansData { get; set; }

        [JsonIgnore]
        public bool IgnorePickupData { get;set;}

        [JsonIgnore]
        public bool IgnoreActualData { get; set; }

        [JsonIgnore]
        public bool IgnoreZReadData { get; set; }

        public bool ShouldSerializeLoansAmount()
        {
            return !IgnoreLoansData;
        }

        public bool ShouldSerializeLoansCount()
        {
            return !IgnoreLoansData;
        }

        public bool ShouldSerializePickupsAmount()
        {
            return !IgnorePickupData;
        }

        public bool ShouldSerializePickupsCount()
        {
            return !IgnorePickupData;
        }

        public bool ShouldSerializeActualAmount()
        {
            return !IgnoreActualData;
        }

        public bool ShouldSerializeActualCount()
        {
            return !IgnoreActualData;
        }

        public bool ShouldSerializeZReadsAmount()
        {
            return !IgnoreZReadData;
        }

        public bool ShouldSerializeZReadsCount()
        {
            return !IgnoreZReadData;
        }
    }
}
