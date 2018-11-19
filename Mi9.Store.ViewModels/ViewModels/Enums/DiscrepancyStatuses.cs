using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum DiscrepancyStatuses
    {
        [Description("N")]
        New,
        [Description("C")]
        Closed
    }

    public class DiscrepancyStatus
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class DiscrepancyStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<DiscrepancyStatus> Items { get; set; }

        public DiscrepancyStatusCatalog()
        {
            Items = new List<DiscrepancyStatus>
                {
                    new DiscrepancyStatus
                        {
                            Id = "N",
                            Description = "catalogs.discrepancyStatus.new"
                        },
                    new DiscrepancyStatus
                        {
                            Id = "C",
                            Description = "catalogs.discrepancyStatus.closed"
                        }
                };
        }
    }
}
