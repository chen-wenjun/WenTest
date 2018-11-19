using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReconcileWithdrawalPosViewModel
    {
        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "cashier")]
        public CashierViewModel Cashier { get; set; }

        [JsonProperty(PropertyName = "approved")]
        public bool Approved { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "denominations")]
        public TenderTypeTotal[] Totals { get; set; }

        public class TenderTypeTotal
        {
            [JsonProperty(PropertyName = "tenderType")]
            public TenderTypeObject TenderType { get; set; }

            [JsonProperty(PropertyName = "cashierTotal")]
            public decimal CashierTotal { get; set; }

            [JsonProperty(PropertyName = "posTotal")]
            public decimal PosTotal { get; set; }

            [JsonProperty(PropertyName = "diff")]
            public decimal Difference
            {
                get
                {
                    return CashierTotal - PosTotal;
                }
            }

            public class TenderTypeObject
            {
                [JsonProperty(PropertyName = "id")]
                public byte TenderCode { get; set; }

                [JsonProperty(PropertyName = "name")]
                public string Description { get; set; }
            }
        }
    }
}