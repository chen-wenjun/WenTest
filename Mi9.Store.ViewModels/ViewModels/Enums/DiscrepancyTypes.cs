using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum DiscrepancyTypes
    {
        [Description("DAMAGE")]
        Damage,
        [Description("OVER")]
        Over,
        [Description("SHORT")]
        Short
    }

    public class DiscrepancyType
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class DiscrepancyTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<DiscrepancyType> Items { get; set; }

        public DiscrepancyTypeCatalog()
        {
            Items = new List<DiscrepancyType>
                {
                    new DiscrepancyType
                        {
                            Value = "DAMAGE",
                            Description = "catalogs.discrepancyType.damaged"
                        },
                    new DiscrepancyType
                        {
                            Value = "OVER",
                            Description = "catalogs.discrepancyType.over"
                        },
                    new DiscrepancyType
                        {
                            Value = "SHORT",
                            Description = "catalogs.discrepancyType.short"
                        }
                };
        }
    }
}
