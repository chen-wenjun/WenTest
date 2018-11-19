using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum CustomerOrderStatuses
    {
        [Description("A")]
        Active,
        [Description("C")]
        Cancelled,
        [Description("F")]
        Finalized
    }

    public class CustomerOrderStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class CustomerOrderStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<CustomerOrderStatus> Items { get; set; }

        public CustomerOrderStatusCatalog()
        {
            Items = new List<CustomerOrderStatus>
                {
                    new CustomerOrderStatus
                        {
                            Value = "A",
                            Description = "catalogs.customerOrderStatus.active"
                        },
                    new CustomerOrderStatus
                        {
                            Value = "C",
                            Description = "catalogs.customerOrderStatus.cancelled"
                        },
                        new CustomerOrderStatus
                        {
                            Value = "F",
                            Description = "catalogs.customerOrderStatus.finalized"
                        },
                    
                };
        }
    }
}
