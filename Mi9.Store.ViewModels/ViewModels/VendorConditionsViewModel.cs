using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class VendorConditionsViewModel
    {
        [JsonProperty(PropertyName = "paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty(PropertyName = "invoiceTerms")]
        public string InvoiceTerms { get; set; }

        [JsonProperty(PropertyName = "shippingFobTerms")]
        public string ShippingFobTerms { get; set; }

        [JsonProperty(PropertyName = "shipVia")]
        public string ShipVia { get; set; }

        [JsonProperty(PropertyName = "specialInstructions1")]
        public string SpecialInstructions1 { get; set; }

        [JsonProperty(PropertyName = "specialInstructions2")]
        public string SpecialInstructions2 { get; set; }

        [JsonProperty(PropertyName = "shippingInstructions")]
        public string ShippingInstructions { get; set; }

        [JsonProperty(PropertyName = "freightMethod")]
        public string FreightMethod { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
    }
}