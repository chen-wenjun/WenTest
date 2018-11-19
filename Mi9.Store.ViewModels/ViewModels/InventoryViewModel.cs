using System;
using Newtonsoft.Json;
namespace Mi9.Store.ViewModels.ViewModels
{
    public class InventoryViewModel
    {
        /// <summary>
        /// Gets or sets the InventoryDate.
        /// </summary>
        [JsonProperty(PropertyName = "inventoryDate")]
        public DateTime InventoryDate { get; set; }

        /// <summary>
        /// Gets or sets the InventoryLib.
        /// </summary>
        [JsonProperty(PropertyName = "inventoryLib")]
        public DateTime InventoryLib { get; set; }

        /// <summary>
        /// Gets or sets the StatusCode.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }
    }
}
