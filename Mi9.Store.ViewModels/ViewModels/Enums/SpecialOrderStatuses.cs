using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SpecialOrderStatuses
    {
        [Description("PC")]
        AwaitingConfirmation,
        [Description("CO")]
        Confirmed,
        [Description("TR")]
        InTransit,
        [Description("RM")]
        ReceivedAtMdc,
        [Description("RT")]
        ReceivedAtStore,
        [Description("DI")]
        Available,
        [Description("RE")]
        CompletedSold,
        [Description("EN")]
        Delivered,
    }

    public class SpecialOrderStatus
    {
        [JsonProperty(PropertyName = "code")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SpecialOrderStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SpecialOrderStatus> Items { get; set; }

        public SpecialOrderStatusCatalog()
        {
            Items = new List<SpecialOrderStatus>
                {
                    new SpecialOrderStatus
                        {
                            Value = "PC",
                            Description = "catalogs.specialOrderStatus.awaitingConfirmation"
                        },
                    new SpecialOrderStatus
                        {
                            Value = "CO",
                            Description = "catalogs.specialOrderStatus.confirmed"
                        },
                        new SpecialOrderStatus
                        {
                            Value = "TR",
                            Description = "catalogs.specialOrderStatus.inTransit"
                        },
                    new SpecialOrderStatus
                        {
                            Value = "RM",
                            Description = "catalogs.specialOrderStatus.receivedAtMdc"
                        },
                         new SpecialOrderStatus
                        {
                            Value = "RT",
                            Description = "catalogs.specialOrderStatus.receivedAtStore"
                        },
                        new SpecialOrderStatus
                        {
                            Value = "DI",
                            Description = "catalogs.specialOrderStatus.available"
                        },
                        new SpecialOrderStatus
                        {
                            Value = "RE",
                            Description = "catalogs.specialOrderStatus.completedSold"
                        },
                    new SpecialOrderStatus
                        {
                            Value = "EN",
                            Description = "catalogs.specialOrderStatus.delivered"
                        }
                };
        }
    }
}
