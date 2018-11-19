using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum TransferTypes
    {
        [Description("S")]
        Suggestion,
        [Description("T")]
        Transfer
    }

    public class TransferType
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class TransferTypeCatalog
    {
        public IList<TransferType> Items { get; set; }

        public TransferTypeCatalog()
        {
            Items = new List<TransferType>
            { 
                new TransferType
                {
                    Id = "S",
                    Description = "Suggestion"
                },
                new TransferType
                {
                    Id = "T",
                    Description = "Transfer"
                }
            };
        }
    }
}
