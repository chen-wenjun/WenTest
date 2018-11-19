using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SkuStatuses
    {
        [Description("D")]
        DUnknown,
        [Description("M")]
        MUnknown,
        [Description("O")]
        OUnknown,
        [Description("R")]
        RUnknown,
        [Description("S")]
        SUnknown,
        [Description("X")]
        XUnknown
    }

    public class SkuStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SkuStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SkuStatus> Items { get; set; }

        public SkuStatusCatalog()
        {
            Items = new List<SkuStatus>
                {
                    new SkuStatus
                        {
                            Value = "D",
                            Description = "catalogs.skuStatus.dUnknown"
                        },
                    new SkuStatus
                        {
                            Value = "M",
                            Description = "catalogs.skuStatus.mUnknown"
                        },
                    new SkuStatus
                        {
                            Value = "O",
                            Description = "catalogs.skuStatus.oUnknown"
                        },
                    new SkuStatus
                        {
                            Value = "R",
                            Description = "catalogs.skuStatus.rUnknown"
                        },
                    new SkuStatus
                        {
                            Value = "S",
                            Description = "catalogs.skuStatus.sUnknown"
                        },
                    new SkuStatus
                        {
                            Value = "X",
                            Description = "catalogs.skuStatus.xUnknown"
                        }
                };
        }
    }
}
