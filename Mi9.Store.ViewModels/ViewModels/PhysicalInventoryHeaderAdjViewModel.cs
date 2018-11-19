using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhysicalInventoryHeaderAdjViewModel
    {
        /// <summary>
        /// Gets or sets the InventoryEntity Id.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the InventoryEntity Date.
        /// </summary>
        [JsonProperty(PropertyName = "countDate")]
        public DateTime? CountDate { get; set; }
        
    }
}
