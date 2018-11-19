using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class OrderItemViewModel : IValidatableObject
    {
        private DateTime _deliveryDate;

        private string _deliveryMethod;

        public OrderItemViewModel()
        {
            DeliveryType = "Home Depot Delivers";
            DelDate = DateTime.Now;
            Notes = string.Empty;
            UPC = string.Empty;
            Status = "A";
        }

        [JsonProperty(PropertyName = "orderNumber")]
        public int OrderNumber { get; set; }

        [JsonProperty(PropertyName = "orderSeqNumber")]
        public short OrdSeqNumber { get; set; }

        [JsonProperty(PropertyName = "poNumber")]
        public string PONumber { get; set; }

        [JsonProperty(PropertyName = "orderedQuantity")]
        public decimal OrderedQuantity { get; set; }

        [JsonProperty(PropertyName = "deliveryType")]
        public string DeliveryType { get; set; }

        public string OrderDetType { get; set; }

        [JsonProperty(PropertyName = "deliveryMethod")]
        public string DeliveryMethod
        {
            get
            {
                return string.IsNullOrWhiteSpace(_deliveryMethod) ? "Take" : _deliveryMethod;
            }
            set
            {
                _deliveryMethod = value;
            }
        }

        [JsonProperty(PropertyName = "isDisableDeliveryMethod")]
        public bool IsDisableDeliveryMethod { get; set; }

        [JsonProperty(PropertyName = "maneuverDistance")]
        public short DeliveryManeuverDistance { get; set; }

        [JsonProperty(PropertyName = "maneuverElevation")]
        public short DeliveryManeuverElevation { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        public long? SKU { get; set; }

        public DateTime? DelDate { get; set; }

        public decimal RetailPrice { get; set; }

        public string PriceLabel { get; set; }

        public string InstallationServiceType { get; set; }

        public decimal PriceWithoutTaxes
        {
            get
            {
                return HasTaxes
                    ? ItemSku.Tax.IsTaxIncluded
                        ? ItemSku.RetailPrice - TaxAmount
                        : ItemSku.RetailPrice
                    : ItemSku.RetailPrice;
            }
        }

        [JsonProperty(PropertyName = "spvApplied")]
        public bool IsSpvApplied { get; set; }

        [JsonProperty(PropertyName = "item")]
        public ItemSkuViewModel ItemSku { get; set; }

        public string UPC { get; set; }

        public bool HasTaxes
        {
            get
            {
                return (ItemSku != null && ItemSku.Tax != null && ItemSku.Tax.TaxRate.HasValue);
            }
        }

        public decimal ExtendedAmount
        {
            get
            {
                if (ItemSku == null)
                    return 0;
                if (ItemSku.PriceLabel != "P")
                    return HasTaxes
                        ? Math.Round(OrderedQuantity * Math.Round(Math.Round(ItemSku.RetailPrice * (1 + ItemSku.Tax.TaxRate.Value / 100), 2) / (1 + ItemSku.Tax.TaxRate.Value / 100), 2), 2)
                        : Math.Round(OrderedQuantity * ItemSku.RetailPrice + 0.004m, 2);

                // the item belongs to a kit
                return ItemSku.KitPrice;
            }
        }

        public decimal ExtendedAmountWithoutTaxes
        {
            get
            {
                return (ItemSku == null) ? 0 : Math.Round(OrderedQuantity * PriceWithoutTaxes, 2, MidpointRounding.AwayFromZero);
            }
        }

        public decimal TaxAmount
        {
            get
            {
                return (ItemSku == null)
                    ? 0
                    : HasTaxes
                        ? Math.Round(ItemSku.RetailPrice * (ItemSku.Tax.TaxRate.Value / 100), 2, MidpointRounding.AwayFromZero)
                        : 0;
            }
        }

        [JsonProperty("extendedTaxAmount")]
        public decimal ExtendedTaxAmount
        {
            get { return Math.Round(OrderedQuantity * TaxAmount, 2, MidpointRounding.AwayFromZero); }
        }

        [JsonProperty(PropertyName = "deliveryDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime DeliveryDate
        {
            get
            {
                var specifyDate = _deliveryDate != DateTime.MinValue ? _deliveryDate : ItemSku != null ? ItemSku.DeliveryDate : DateTime.Now.AddDays(2);
                return specifyDate;
            }

            set
            {
                _deliveryDate = value;
            }
        }

        [JsonProperty(PropertyName = "SKUDesc")]
        public string SKUDesc { get; set; }

        [JsonProperty(PropertyName = "blockReason")]
        public string BlockReason { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ItemSku == null)
            {
                yield return new ValidationResult("Item is required field");
            }
        }

        public string UOM { get; set; }

        public string LineMessage { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "promoPrice")]
        public decimal? PromoPrice
        {
            get { return ItemSku != null ? ItemSku.PromoPrice : null; }
        }

        [JsonProperty(PropertyName = "InstallationServiceId")]
        public int? InstallationServiceId { get; set; }
    }
}