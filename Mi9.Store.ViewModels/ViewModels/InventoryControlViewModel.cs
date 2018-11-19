using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class InventoryControlViewModel
    {
        [JsonProperty(PropertyName = "inventoryAdjustmentLimit")]
        public decimal InventoryAdjustmentLimit { get; set; }
    }
}