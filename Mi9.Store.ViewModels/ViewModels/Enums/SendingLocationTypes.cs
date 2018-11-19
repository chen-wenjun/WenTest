using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum SendingLocationTypes
    {
        [Description("Nearby")]
        Nearby = 1,
        [Description("Same District")]
        SameDistrict,
        [Description("Authorized")]
        Authorized
    }

    public class SendingLocationType
    {
        [JsonProperty(PropertyName = "value")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class SendingLocationTypesCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<SendingLocationType> Items { get; set; }

        public SendingLocationTypesCatalog()
        {
            Items = new List<SendingLocationType>
                {
                    new SendingLocationType
                        {
                            Id = 1,
                            Description = "catalogs.sendingLocationType.nearby"
                        },
                    new SendingLocationType
                        {
                            Id = 2,
                            Description = "catalogs.sendingLocationType.sameDistrict"
                        },
                    new SendingLocationType
                        {
                            Id = 3,
                            Description = "catalogs.sendingLocationType.authorized"
                        }
                };
        }
    }
}
