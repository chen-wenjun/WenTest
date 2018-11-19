using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TenderTransactionViewModel
    {
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "sum")]
        public decimal Sum { get; set; }
    }
}