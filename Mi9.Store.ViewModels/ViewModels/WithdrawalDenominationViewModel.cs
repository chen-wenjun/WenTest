using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   public class TenderTypeDenominationsViewModel
    {
        public TenderTypeDenominationsViewModel()
        {
            Default = new DefaultDenomination[0];
            Cards = new Card[0];
        }

        [JsonProperty(PropertyName = "tender")]
        public Tender TenderObject { get; set; }

        [JsonProperty(PropertyName = "tenderType")]
        public TenderType TenderTypeObject { get; set; }

        [JsonProperty(PropertyName = "other")]
        public OtherDenomination Other { get; set; }

        [JsonProperty(PropertyName = "cards")]
        public Card[] Cards { get; set; }

        [JsonProperty(PropertyName = "default")]
        public DefaultDenomination[] Default { get; set; }

        public bool ShouldSerializeOther()
        {
            return this.Other != null;
        }

        public bool ShouldSerializeDefault()
        {
            return this.Default != null;
        }

        public bool ShouldSerializeCards()
        {
            return this.Cards != null;
        }

        public bool ShouldSerializeTenderObject()
        {
            return this.TenderObject != null;
        }

        public class OtherDenomination
        {
            
            [JsonProperty(PropertyName = "count")]
            public int Count { get; set; }

            [JsonProperty(PropertyName = "total")]
            public decimal Total { get; set; }
        }

        
        public class Tender
        {
            [JsonProperty(PropertyName = "id")]
            public int Id { get; set; }

            [JsonProperty(PropertyName = "key")]
            public string Key { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }
        }

        public class TenderType
        {
            [JsonProperty(PropertyName = "id")]
            public byte TenderCode { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Description { get; set; }
        }

        public class DefaultDenomination
        {
            [JsonProperty(PropertyName = "denomination")]
            public Denomination DenominationObject { get; set; }

            [JsonProperty(PropertyName = "count")]
            public int Count { get; set; }

            [JsonProperty(PropertyName = "totalInPesos")]
            public decimal TotalInPesos { get; set; }

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

        public class Card
        {
            [JsonProperty(PropertyName = "number")]
            public string Number { get; set; }

            [JsonProperty(PropertyName = "sum")]
            public decimal Sum { get; set; }
        }
    }
}