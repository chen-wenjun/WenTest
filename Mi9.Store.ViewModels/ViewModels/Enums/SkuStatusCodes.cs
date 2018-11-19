using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SkuStatusCodes
    {
        [Description("A")]
        Active,
        [Description("D")]
        Discontinued,
        [Description("E")]
        Eliminated,
        [Description("P")]
        Promotion,
        [Description("T")]
        Test,
        [Description("I")]
        Inactive,
    }

    public class SkuStatusCode
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SkuStatusCodeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SkuStatusCode> Items { get; set; }

        public SkuStatusCodeCatalog()
        {
            Items = new List<SkuStatusCode>
                {
                    new SkuStatusCode
                        {
                            Value = "A",
                            Description = "catalogs.skuStatusCode.active"
                        },
                    new SkuStatusCode
                        {
                            Value = "D",
                            Description = "catalogs.skuStatusCode.discontinued"
                        },
                    new SkuStatusCode
                        {
                            Value = "E",
                            Description = "catalogs.skuStatusCode.eliminated"
                        },
                    new SkuStatusCode
                        {
                            Value = "P",
                            Description = "catalogs.skuStatusCode.promotion"
                        },
                    new SkuStatusCode
                        {
                            Value = "T",
                            Description = "catalogs.skuStatusCode.test"
                        },
                    new SkuStatusCode
                        {
                            Value = "I",
                            Description = "catalogs.skuStatusCode.inactive"
                        }
                };
        }
    }
}
