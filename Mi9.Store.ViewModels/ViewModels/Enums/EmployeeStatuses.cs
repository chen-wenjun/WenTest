using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum EmployeeStatuses
    {
        [Description("Salaried")]
        Salaried = 1,
        [Description("Temporary")]
        Temporary,
        [Description("RFT")]
        RegularFullTime,
        [Description("RPT")]
        RegularPartTime,
        [Description("TPT")]
        TemporalPartTime,
        [Description("TFT")]
        TemporalFullTime
    }

    public class EmployeeStatus
    {
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class EmployeeStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<EmployeeStatus> Items { get; set; }

        public EmployeeStatusCatalog()
        {
            Items = new List<EmployeeStatus>
                {
                    new EmployeeStatus
                        {
                            Value = 1,
                            Description = "catalogs.employeeStatus.salaried"
                        },
                    new EmployeeStatus
                        {
                            Value = 2,
                            Description = "catalogs.employeeStatus.temporary"
                        },
                    new EmployeeStatus
                        {
                            Value = 3,
                            Description = "catalogs.employeeStatus.rft"
                        },
                    new EmployeeStatus
                        {
                            Value = 4,
                            Description = "catalogs.employeeStatus.rpt"
                        },
                    new EmployeeStatus
                        {
                            Value = 5,
                            Description = "catalogs.employeeStatus.tpt"
                        },
                    new EmployeeStatus
                        {
                            Value = 6,
                            Description = "catalogs.employeeStatus.tft"
                        }
                };
        }
    }
}
