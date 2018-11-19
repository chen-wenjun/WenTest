using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{

    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSkuViewModel : IValidatableObject
    {
        [JsonProperty(PropertyName = "marginLimit")]
        public decimal MarginLimit { get; set; } //todo set this parameter in service item constructor  decimal.Parse(ConfigurationManager.AppSettings["SkuMarginThreshold"]);

        [JsonProperty(PropertyName = "number")]
        public long Sku { get; set; }

        [JsonProperty(PropertyName = "sequenceNumber")]
        public short SequenceNumber { get; set; }


        [JsonProperty(PropertyName = "serviceId")]
        public int? ServiceId { get; set; }

        [JsonProperty(PropertyName = "refundRequestId")]
        public int? RefundRequestId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "soItemType")]
        public string SpecialItemType { get; set; }

        [JsonProperty(PropertyName = "keyword")]
        public string Keyword { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public string VendorName { get; set; }

        [JsonProperty(PropertyName = "vendorModel")]
        public string VendPartNo { get; set; }

        [JsonProperty(PropertyName = "vendorId")]
        public string VendorId { get; set; }

        [JsonProperty(PropertyName = "vendorSuffix")]
        public byte? VendorKey { get; set; }

        [JsonProperty(PropertyName = "vendorPackInfo")]
        public VendorPackInfoViewModel VendorPackInfo { get; set; }

        [JsonProperty(PropertyName = "vendorPack")]
        public short VendorPack { get; set; }

        [JsonProperty(PropertyName = "vendorShipType")]
        public string VendorShipType { get; set; }

        [JsonProperty(PropertyName = "vendorCollectCost")]
        public decimal? VendorCollectCost { get; set; }

        [JsonProperty(PropertyName = "vendorPrepaidCost")]
        public decimal? VendorPrepaidCost { get; set; }

        [JsonProperty(PropertyName = "classId")]
        public short? ClassId { get; set; }

        [JsonProperty(PropertyName = "department")]
        public string Department { get; set; }

        [JsonProperty(PropertyName = "departmentObj")]
        public DepartmentViewModel DepartmentObj { get; set; }

        [JsonProperty(PropertyName = "priceLabel")]
        public string PriceLabel { get; set; }

        [JsonProperty(PropertyName = "spvApplied")]
        public bool IsSpvApplied { get; set; }

        [JsonProperty(PropertyName = "defaultLabel")]
        public string DefaultLabel { get; set; }

        [JsonProperty(PropertyName = "retailPrice")]
        public decimal RetailPrice { get; set; }

        [JsonProperty(PropertyName = "defaultPrice")]
        public decimal DefaultPrice { get; set; }

        [JsonProperty(PropertyName = "initialPrice")]
        public decimal InitialPrice { get; set; }

        [JsonProperty(PropertyName = "sourcePrice")]
        public decimal SourcePrice { get; set; }

        [JsonProperty(PropertyName = "onOrder")]
        public decimal OnOrder { get; set; }

        [JsonProperty(PropertyName = "last4WeekSales")]
        public decimal Last4WeekSales { get; set; }

        [JsonProperty(PropertyName = "last13WeekSales")]
        public decimal Last13WeekSales { get; set; }

        [JsonProperty(PropertyName = "ytdSales")]
        public decimal YtdSales { get; set; }

        [JsonProperty(PropertyName = "onXDock")]
        public int OnXDock { get; set; }

        [JsonProperty(PropertyName = "inTransit")]
        public decimal InTransit { get; set; }

        [JsonProperty(PropertyName = "displayQty")]
        public decimal DisplayQty { get; set; }

        [JsonProperty(PropertyName = "modelStock")]
        public int StorModelStk { get; set; }

        [JsonProperty(PropertyName = "weeksOfInventory")]
        public decimal WeeksOfInventory { get;set;}

        [JsonProperty(PropertyName = "priceIncTax")]
        public decimal PriceIncTax { get; set; }

        [JsonProperty(PropertyName = "unitCost")]
        public decimal Cost { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty(PropertyName = "available")]
        public decimal Available { get; set; }

        [JsonProperty(PropertyName = "preCountOnHand")]
        public decimal PreCountOnHand { get; set; }

        [JsonProperty(PropertyName = "quantityOnHand")]
        public decimal QuantityOnHand { get; set; }

        [JsonProperty(PropertyName = "taxCode")]
        public string TaxCode { get; set; }

        [JsonProperty(PropertyName = "velocityCode")]
        public string VelocityCode { get; set; }

        [JsonProperty(PropertyName = "propricingType")]
        public string ProPricingType { get; set; }


        [JsonProperty(PropertyName = "isFractionalQuantity")]
        public bool IsFractionalQuantity
        {
            get
            {
                return UnitOfMeasure != null && UnitOfMeasure.IsFractionalQuantityAllowed;
            }
        }

        public DateTime DeliveryDate
        {
            get
            {
                var now = DateTime.Now;
                if (!string.IsNullOrWhiteSpace(SkuItemType) && SkuItemType.Trim().ToLower() == "pro")
                {
                    return Available > 0 ? now.AddDays(1) : now.AddDays(3);
                }

                return Available > 0 ? now.AddDays(2) : now.AddDays(3);
            }
        }


        [JsonProperty(PropertyName = "promoStart")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? PromoStart { get; set; }

        [JsonProperty(PropertyName = "promoEnd")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? PromoEnd { get; set; }

        [JsonProperty(PropertyName = "promoPrice")]
        public decimal? PromoPrice { get; set; }

        [JsonProperty(PropertyName = "margin")]
        public decimal Margin { get; set; }

        public decimal MarginAbs { get; set; }

        [JsonProperty(PropertyName = "needMarginConfirmation")]
        public bool NeedMarginConfirmation
        {
            get
            {
                return Margin > MarginLimit;
            }
        }

        [JsonProperty(PropertyName = "reserved")]
        public int Reserved { get; set; }

        [JsonProperty(PropertyName = "itemType")]
        public string ItemType { get; set; }

        [JsonProperty(PropertyName = "itemTypeLarge")]
        public string ItemTypeLarge { get; set; }

        [JsonProperty(PropertyName = "skuItemType")]
        public string SkuItemType { get; set; }

        [JsonProperty(PropertyName = "skuItemTypeDescription")]
        public string SkuItemDescription { get; set; }

        [JsonProperty(PropertyName = "isKitHeader")]
        public bool IsKitHeader { get; set; }

        [JsonProperty(PropertyName = "kitPrice")]
        public decimal KitPrice { get; set; }

        public decimal KitQuantity { get; set; }

        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public decimal Weight { get; set; }

        [JsonProperty(PropertyName = "cube")]
        public decimal Cube { get; set; }

        [JsonProperty(PropertyName = "unitOfMeasure")]
        public UnitOfMeasureViewModel UnitOfMeasure { get; set; }

        [JsonProperty(PropertyName = "tax")]
        public TaxViewModel Tax { get; set; }

        public IEnumerable<ItemSkuViewModel> KitItems { get; set; }
        //public IEnumerable<ItemSkuViewModel> KitItems { get; set; } todo remove reader and change List to IEnumerable to optimize queries

        [JsonProperty(PropertyName = "kitItems")]
        public IEnumerable<OrderItemViewModel> KitItemsForOrder
        {
            get
            {
                if (KitItems != null && KitItems.Any())
                {
                    return KitItems.Select((t, i) => new OrderItemViewModel { ItemSku = t, OrderedQuantity = t.KitQuantity, OrdSeqNumber = (short)i });
                }
                return null;
            }
        }

        [JsonProperty(PropertyName = "barCodes")]
        public List<string> BarCodes { get; set; }

        [JsonProperty(PropertyName = "selectedBarCode")]
        public string BarCode { get; set; }

        [JsonProperty(PropertyName = "feeId")]
        public int? FeeId { get; set; }

        [JsonProperty(PropertyName = "promotions")]
        public List<PromotionViewModel> Promotions { get; set; }

        [JsonProperty(PropertyName = "seasons")]
        public List<SeasonViewModel> Seasons { get; set; }

        [JsonProperty(PropertyName = "departmentClass")]
        public DepartmentClassViewModel DepartmentClass { get; set; }

        [JsonProperty(PropertyName = "departmentSubClass")]
        public DepartmentSubClassViewModel DepartmentSubClass { get; set; }

        [JsonProperty(PropertyName = "vendorSKU")]
        public string VendorSKU { get; set; }

        [JsonProperty(PropertyName = "uomConvert")]
        public decimal UOMConvert { get; set; }

        [JsonProperty(PropertyName = "LabelType")]
        public string LabelType { get; set; }

        [JsonProperty(PropertyName = "labelTypeDescription")]
        public string LabelTypeDescription { get; set; }

        [JsonProperty(PropertyName = "numberOfLabel")]
        public byte NumberLabels { get; set; }

        [JsonProperty(PropertyName = "upc")]
        public string Upc { get; set; }

        [JsonProperty(PropertyName = "promoType")]
        public byte PromoType { get; set; }

        [JsonProperty(PropertyName = "PromoDealPrice")]
        public decimal PromoDealPrice { get; set; }

        [JsonProperty(PropertyName = "PromoDealQty")]
        public int PromoDealQty { get; set; }

        [JsonProperty(PropertyName = "DealPrice")]
        public decimal DealPrice { get; set; }

        [JsonProperty(PropertyName = "DealQty")]
        public int DealQty { get; set; }

        [JsonProperty(PropertyName = "poPlacement")]
        public string POplacement { get; set; }

        [JsonProperty(PropertyName = "reviewDate")]
        public DateTime? ReviewDate { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "homelocation")]
        public string HomeLocation { get; set; }

        [JsonProperty(PropertyName = "IsSpecialItem")]
        public bool IsSpecialItem { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!(Sku > 0))
            {
                yield return new ValidationResult("Number must be greater than 0");
            }
        }
    }
}