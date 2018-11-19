using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SkuUniqueItemCodes
    {
        [Description("A")]
        Alternate,
        [Description("B")]
        SpecialBuy,
        //[Description("D")]
        //DUnknown,
        //[Description("I")]
        //Invalid,
        [Description("L")]
        SpecialOrderCataloged,
        [Description("S")]
        SpecialOrderGeneric,
        [Description("Z")]
        Primary
    }

    public class SkuUniqueItemCode
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SkuUniqueItemCodeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SkuUniqueItemCode> Items { get; set; }

        public SkuUniqueItemCodeCatalog()
        {
            Items = new List<SkuUniqueItemCode>
                {
                    new SkuUniqueItemCode
                        {
                            Value = "A",
                            Description = "catalogs.skuUniqueItemCode.alternate"
                        },
                    new SkuUniqueItemCode
                        {
                            Value = "B",
                            Description = "catalogs.skuUniqueItemCode.specialBuy"
                        },
                    //new SkuUniqueItemCode
                    //    {
                    //        Value = "D",
                    //        Description = "catalogs.skuUniqueItemCode.dUnknown"
                    //    },
                    //new SkuUniqueItemCode
                    //    {
                    //        Value = "I",
                    //        Description = "catalogs.skuUniqueItemCode.iUnknown"
                    //    },
                    new SkuUniqueItemCode
                        {
                            Value = "L",
                            Description = "catalogs.skuUniqueItemCode.specialOrderCataloged"
                        },
                    new SkuUniqueItemCode
                        {
                            Value = "S",
                            Description = "catalogs.skuUniqueItemCode.specialOrderGeneric"
                        },
                    new SkuUniqueItemCode
                        {
                            Value = "Z",
                            Description = "catalogs.skuUniqueItemCode.primary"
                        }
                };
        }
    }
}
