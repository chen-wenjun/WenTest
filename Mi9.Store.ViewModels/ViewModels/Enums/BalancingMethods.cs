using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum BalancingMethods
    {
        [Description("cashier")]
        Cashier,
        [Description("register")]
        Register,
        [Description("both")]
        Both
    }

    public class BalancingMethod
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class BalancingMethodCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<BalancingMethod> Items { get; set; }

        public BalancingMethodCatalog()
        {
            Items = new List<BalancingMethod>
                {
                    new BalancingMethod
                        {
                            Value = EnumHelper.GetDescription(BalancingMethods.Cashier),
                            Description = "catalogs.balancingMethods.cashier"
                        },
                    new BalancingMethod
                        {
                            Value = EnumHelper.GetDescription(BalancingMethods.Register),
                            Description = "catalogs.balancingMethods.register"
                        }
                        ,
                    new BalancingMethod
                        {
                            Value = EnumHelper.GetDescription(BalancingMethods.Both),
                            Description = "catalogs.balancingMethods.both"
                        }
                };
        }
    }
}
