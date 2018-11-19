using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum StoreStatuses
    {
        [Description("N")]
        New,
        [Description("O")]
        Open,
        [Description("C")]
        Closed,
        [Description("S")]
        Suspended,
        [Description("D")]
        Deleted
    }

    public class StoreStatus
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }


    }

    public class StoreStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<TransferStatus> Items { get; set; }

        public StoreStatusCatalog()
        {
            Items = new List<TransferStatus>
                {
                    new TransferStatus
                        {
                            Id = "N",
                            Description = "catalogs.storeStatus.new"
                        },
                    new TransferStatus
                        {
                            Id = "O",
                            Description = "catalogs.storeStatus.open"
                        },
                    new TransferStatus
                        {
                            Id = "C",
                            Description = "catalogs.storeStatus.closed"
                        },
                    new TransferStatus
                        {
                            Id = "S",
                            Description = "catalogs.storeStatus.suspended"
                        },
                        new TransferStatus
                        {
                            Id = "D",
                            Description = "catalogs.storeStatus.deleted"
                        }
                };
        }
    }
}
