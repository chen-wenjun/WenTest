using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum BooleanStates
    {
        [Description("false")]
        False,
        [Description("true")]
        True
    }

    public class BooleanState
    {
        [JsonProperty(PropertyName = "value")]
        public bool Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class BooleanStateCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<BooleanState> Items { get; set; }

        public BooleanStateCatalog()
        {
            Items = new List<BooleanState>
                {
                    new BooleanState
                        {
                            Value = false,
                            Description = "catalogs.booleanState.false"
                        },
                    new BooleanState
                        {
                            Value = true,
                            Description = "catalogs.booleanState.true"
                        }
                };
        }
    }
}
