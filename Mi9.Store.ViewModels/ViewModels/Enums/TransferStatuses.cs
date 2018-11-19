using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum TransferStatuses
    {
        [Description("A")]
        Approved,
        [Description("N")]
        New,
        [Description("P")]
        InProcess,
        [Description("R")]
        Received,
        [Description("S")]
        Shipped,
        [Description("V")]
        Voided
    }

    public class TransferStatus
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }


    }

    public class TransferStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<TransferStatus> Items { get; set; }

        public TransferStatusCatalog()
        {
            Items = new List<TransferStatus>
                {
                    new TransferStatus
                        {
                            Id = "A",
                            Description = "catalogs.transferStatus.approved"
                        },
                    new TransferStatus
                        {
                            Id = "N",
                            Description = "catalogs.transferStatus.new"
                        },
                    new TransferStatus
                        {
                            Id = "P",
                            Description = "catalogs.transferStatus.inProcess"
                        },
                    new TransferStatus
                        {
                            Id = "R",
                            Description = "catalogs.transferStatus.received"
                        },
                        new TransferStatus
                        {
                            Id = "S",
                            Description = "catalogs.transferStatus.shipped"
                        },
                    new TransferStatus
                        {
                            Id = "V",
                            Description = "catalogs.transferStatus.voided"
                        },
                };
        }
    }
}
