using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SkuTypes
    {
        [Description("A")]
        AUnknown,
        [Description("E")]
        EUnknown,
        [Description("G")]
        GUnknown,
        [Description("M")]
        MUnknown,
        [Description("N")]
        Normal
    }

    public class SkuType
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SkuTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SkuType> Items { get; set; }

        public SkuTypeCatalog()
        {
            Items = new List<SkuType>
                {
                    new SkuType
                        {
                            Value = "A",
                            Description = "catalogs.skuType.aUnknown"
                        },
                    new SkuType
                        {
                            Value = "E",
                            Description = "catalogs.skuType.eUnknown"
                        },
                    new SkuType
                        {
                            Value = "G",
                            Description = "catalogs.skuType.gUnknown"
                        },
                    new SkuType
                        {
                            Value = "M",
                            Description = "catalogs.skuType.mUnknown"
                        },
                    new SkuType
                        {
                            Value = "N",
                            Description = "catalogs.skuType.normal"
                        }
                };
        }
    }
}
