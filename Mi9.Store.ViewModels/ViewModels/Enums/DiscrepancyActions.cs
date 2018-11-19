using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum DiscrepancyActions
    {
        [Description("CLOSE")]
        Close= 1,
        [Description("WITHDRAW")]
        Withdraw,
        [Description("ADJUST")]
        Adjust
    }

    public class DiscrepancyAction
    {
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class DiscrepancyActionCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<DiscrepancyAction> Items { get; set; }

        public DiscrepancyActionCatalog()
        {
            Items = new List<DiscrepancyAction>
                {
                    new DiscrepancyAction
                        {
                            Value = (int)DiscrepancyActions.Close,
                            Description = "catalogs.discrepancyAction.close"
                        },
                        new DiscrepancyAction
                        {
                            Value = (int)DiscrepancyActions.Withdraw,
                            Description = "catalogs.discrepancyAction.withdraw"
                        },
                    new DiscrepancyAction
                        {
                            Value = (int)DiscrepancyActions.Adjust,
                            Description = "catalogs.discrepancyAction.adjust"
                        }
                    
                    
                };
        }
    }
}
