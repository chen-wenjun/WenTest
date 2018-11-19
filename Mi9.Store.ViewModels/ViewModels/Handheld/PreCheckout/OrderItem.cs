// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderItem.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   Defines the OrderItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Mi9.Store.ViewModels.ViewModels;

namespace MI9.HDM.Store.BackOffice.ViewModelService.ViewModels.Handheld.PreCheckout
{
    using Newtonsoft.Json;

    /// <summary>
    /// The order item.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        [JsonProperty(PropertyName = "orderNumber")]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the ord sequence number.
        /// </summary>
        [JsonProperty(PropertyName = "orderSeqNumber")]
        public short OrdSeqNumber { get; set; }

        /// <summary>
        /// Gets or sets the ordered quantity.
        /// </summary>
        [JsonProperty(PropertyName = "Quantity")]
        public decimal OrderedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty(PropertyName = "Sku")]
        public long? SKU { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonProperty(PropertyName = "Price")]
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the sku bar code.
        /// </summary>
        [JsonProperty(PropertyName = "Upc")]
        public string UPC { get; set; }

        /// <summary>
        /// Gets or sets the item sku.
        /// </summary>
        public ItemSkuViewModel ItemSku { get; set; }

        public string VendorID { get; set; }

        public string Status { get; set; }
     }
}
