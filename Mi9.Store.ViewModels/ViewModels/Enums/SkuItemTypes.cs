using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SkuItemTypes
    {
        //[Description("T")]
        //TUnknown,
        //[Description("R")]
        //RUnknown,
        //[Description("E")]
        //EUnknown,
        //[Description("D")]
        //Display,
        //[Description("B")]
        //BUnknown,
        [Description("K")]
        Kit,
        //[Description("C")]
        //CUnknown,
        //[Description("S")]
        //SUnknown,
        [Description("N")]
        Normal

    }

    public class SkuItemType
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SkuItemTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SkuItemType> Items { get; set; }

        public SkuItemTypeCatalog()
        {
            Items = new List<SkuItemType>
                {
                    //new SkuItemType
                    //    {
                    //        Value = "T",
                    //        Description = "catalogs.skuItemType.tUnknown"
                    //    },
                    //new SkuItemType
                    //    {
                    //        Value = "R",
                    //        Description = "catalogs.skuItemType.rUnknown"
                    //    },
                    //new SkuItemType
                    //    {
                    //        Value = "E",
                    //        Description = "catalogs.skuItemType.eUnknown"
                    //    },
                    //new SkuItemType
                    //    {
                    //        Value = "D",
                    //        Description = "catalogs.skuItemType.dUnknown"
                    //    },
                    //new SkuItemType
                    //    {
                    //        Value = "B",
                    //        Description = "catalogs.skuItemType.bUnknown"
                    //    },
                    new SkuItemType
                        {
                            Value = "K",
                            Description = "catalogs.skuItemType.kit"
                        },
                    //new SkuItemType
                    //    {
                    //        Value = "C",
                    //        Description = "catalogs.skuItemType.cUnknown"
                    //    },
                    //new SkuItemType
                    //    {
                    //        Value = "S",
                    //        Description = "catalogs.skuItemType.sUnknown"
                    //    },
                    new SkuItemType
                        {
                            Value = "N",
                            Description = "catalogs.skuItemType.normal"
                        }
                };
        }
    }
}
