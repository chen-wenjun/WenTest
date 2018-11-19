using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SkuLabelTypes
    {
        [Description("F")]
        FUnknown,
        [Description("S")]
        SUnknown
    }

    public class SkuLabelType
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SkuLabelTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SkuItemType> Items { get; set; }

        public SkuLabelTypeCatalog()
        {
            Items = new List<SkuItemType>
                {
                    new SkuItemType
                        {
                            Value = "F",
                            Description = "catalogs.skuLabelType.fUnknown"
                        },
                    new SkuItemType
                        {
                            Value = "S",
                            Description = "catalogs.skuLabelType.sUnknown"
                        }
                };
        }
    }
}
