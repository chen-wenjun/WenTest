using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InventoryAdjustmentViewModel
    {
        /// <summary>
        /// Gets or sets the transaction date.
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Gets or sets the transaction time.
        /// </summary>
        [JsonIgnore]
        public TimeSpan TransactionTime { get; set; }

        /// <summary>
        /// Gets or sets the auto sequence.
        /// </summary>
        [JsonProperty("number")]
        public int AutoSequence { get; set; }

        /// <summary>
        /// Gets or sets the transaction number.
        /// </summary>
        [JsonIgnore]
        public long TransactionNumber { get; set; }

        /// <summary>
        /// Gets or sets the quantity adjusted.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal QuantityAdjusted { get; set; }

        /// <summary>
        /// Gets or sets the quantity adjusted.
        /// </summary>
        [JsonProperty("quantityonHand")]
        public decimal QuantityOnHand { get; set; }

        [JsonProperty("vendorSuffix")]
        public Byte VendorSuffix { get; set; }

        [JsonProperty("vendorId")]
        public string VendorID { get; set; }
        /// <summary>
        /// Gets or sets the current available.
        /// </summary>
        [JsonProperty("available")]
        public decimal CurrentAvailable { get; set; }

        /// <summary>
        /// Gets or sets the retail price.
        /// </summary>
        [JsonProperty("retailPrice")]
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        [JsonProperty("cost")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the new cost.
        /// </summary>
        [JsonProperty("newCost")]
        public decimal NewCost { get; set; }

        /// <summary>
        /// Gets or sets the old cost.
        /// </summary>
        [JsonProperty("oldCost")]
        public decimal OldCost { get; set; }

        /// <summary>
        /// Gets or sets the sku ID.
        /// </summary>
        [JsonProperty("skuId")]
        public long SkuId { get; set; }

        /// <summary>
        /// Gets or sets the reason code.
        /// </summary>
        [JsonIgnore]
        public byte ReasonCode { get; set; }

        /// <summary>
        /// gets or sets a sign value
        /// </summary>
        [JsonProperty("quantityReplace")]
        public bool QuantityReplace { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonIgnore]
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        [JsonIgnore]
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        [JsonIgnore]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets the department.
        /// </summary>
        [JsonProperty(PropertyName = "department")]
        public string Department
        {
            get
            {
                return Sku == null ? null : Sku.Department;
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get
            {
                return Sku == null ? null : Sku.Description;
            }
        }

        /// <summary>
        /// Gets the uom.
        /// </summary>
        [JsonProperty(PropertyName = "uom")]
        public string UOM
        {
            get { return Sku == null || Sku.UnitOfMeasure == null ? null : Sku.UnitOfMeasure.UomId; }
        }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty("sku")]
        public virtual ItemSkuViewModel Sku { get; set; }

        /// <summary>
        /// Gets or sets the ConvetSign field
        /// </summary>
        public string ConvertSign { get; set; }

    }
}
