using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PoTrackingLogTypes
    {
        [Description("APO")]
        Activation,
        [Description("EST")]
        EmailSent,
        [Description("SCH")]
        StatusChange,
        [Description("RVS")]
        ReverseStatus,
        [Description("RSC")]
        ReSchedule,
        [Description("CPO")]
        PoCancelled,
        [Description("CCO")]
        CustomerOrderCancelled
    }

    public class PoTrackingLogType
    {
        [JsonProperty(PropertyName = "code")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PoTrackingLogTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PoTrackingLogType> Items { get; set; }

        public PoTrackingLogTypeCatalog()
        {
            Items = new List<PoTrackingLogType>
                {
                    new PoTrackingLogType
                        {
                            Value = "APO", // A -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.activation"
                        },
                    new PoTrackingLogType
                        {
                            Value = "EST", //X -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.emailSent"
                        },
                    new PoTrackingLogType
                        {
                            Value = "SCH", //C -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.statusChange"
                        },
                    new PoTrackingLogType
                        {
                            Value = "RVS", //R -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.reverseStatus"
                        },
                    new PoTrackingLogType
                        {
                            Value = "RSC", //R -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.reSchedule"
                        },
                    new PoTrackingLogType
                        {
                            Value = "CPO", //C -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.poCancelled"
                        },
                    new PoTrackingLogType
                        {
                            Value = "CCO", //C -> When sent to MMS
                            Description = "catalogs.poTrackingLogType.customerOrderCancelled"
                        },
                };
        }
    }
}
