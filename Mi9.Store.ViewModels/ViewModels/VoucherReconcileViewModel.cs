using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class VoucherReconcileViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int VoucherReconcileId { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "cashier")]
        public CashierViewModel Cashier { get; set; }

        [JsonProperty(PropertyName = "tender")]
        public Tender TenderObject { get; set; }

        [JsonProperty(PropertyName = "other")]
        public OtherDenomination Other { get; set; }

        [JsonProperty(PropertyName = "default")]
        public DefaultDenomination[] Default { get; set; }

        public class Tender
        {
            [JsonProperty(PropertyName = "id")]
            public int Id { get; set; }

            [JsonProperty(PropertyName = "key")]
            public string Key { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }
        }

        public class OtherDenomination
        {
            [JsonProperty(PropertyName = "count")]
            public int? Count { get; set; }

            [JsonProperty(PropertyName = "total")]
            public decimal? Total { get; set; }
        }

        public class DefaultDenomination
        {
            [JsonProperty(PropertyName = "denomination")]
            public Denomination DenominationObject { get; set; }

            [JsonProperty(PropertyName = "count")]
            public int Count { get; set; }

            public class Denomination
            {
                [JsonProperty(PropertyName = "id")]
                public int Id { get; set; }

                [JsonProperty(PropertyName = "description")]
                public string Description { get; set; }

                [JsonProperty(PropertyName = "displayOrder")]
                public int DisplayOrder { get; set; }

                [JsonProperty(PropertyName = "value")]
                public decimal Value { get; set; }
            }
        }
    }
}