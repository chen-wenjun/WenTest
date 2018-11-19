using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhysicalInventoryAdjustmentViewModel
    {
        /// <summary>
        /// Gets or sets active Inventory.
        /// </summary>
        [JsonProperty(PropertyName = "activePhysicalInventory")]
        public PhysicalInventoryViewModel ActivePhysicalInventory { get; set; }

        /// <summary>
        /// Gets or sets active Inventory.
        /// </summary>
        [JsonProperty(PropertyName = "physicalInventoryImportFileRecordsCount")]
        public int PhysicalInventoryImportFileRecordsCount { get; set; }
    }
}
