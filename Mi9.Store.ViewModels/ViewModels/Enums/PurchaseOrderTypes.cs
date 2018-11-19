using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PurchaseOrderTypes
    {
        [Description("A")]
        NewStore,
        [Description("C")]
        Special,
        [Description("R")]
        Regular
    }
    
    public class PurchaseOrderType
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PurchaseOrderTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PurchaseOrderType> Items { get; set; }

        public PurchaseOrderTypeCatalog()
        {
            Items = new List<PurchaseOrderType>
                {
                    new PurchaseOrderType
                        {
                            Value = "A",
                            Description = "catalogs.purchaseOrderType.newStore"
                        },
                        new PurchaseOrderType
                        {
                            Value = "C",
                            Description = "catalogs.purchaseOrderType.special"
                        },
                    new PurchaseOrderType
                        {
                            Value = "R",
                            Description = "catalogs.purchaseOrderType.regular"
                        }
                    
                };
        }
    }
}
