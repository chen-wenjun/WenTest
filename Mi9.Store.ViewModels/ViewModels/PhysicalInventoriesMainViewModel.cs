using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhysicalInventoriesMainViewModel
    {
        /// <summary>
        /// Gets or set the Inventory
        /// </summary>
        [JsonProperty(PropertyName = "inventory")]
        public InventoryViewModel Inventory { get; set; }

        /// <summary>
        /// Gets or set the list of PhysicalInventories
        /// </summary>
        [JsonProperty(PropertyName = "physicalInventories")]
        public IEnumerable<PhysicalInventoryViewModel> PhysicalInventories { get; set; }
    }
}
