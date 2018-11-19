using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PalletAuditStatuses
    {
        [Description("P")]
        InProgress,
        [Description("V")]
        VerifyAudit,
        [Description("C")]
        Completed,
        [Description("I")]
        CompletedWithDiscrepancies
    }

    public class PalletAuditStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PalletAuditStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PalletAuditStatus> Items { get; set; }

        public PalletAuditStatusCatalog()
        {
            Items = new List<PalletAuditStatus>
                {
                    new PalletAuditStatus
                        {
                            Value = "P",
                            Description = "catalogs.palletAuditStatus.pending"
                        },
                    new PalletAuditStatus
                        {
                            Value = "V",
                            Description = "catalogs.palletAuditStatus.verifyAudit"
                        },
                    new PalletAuditStatus
                        {
                            Value = "C",
                            Description = "catalogs.palletAuditStatus.completed"
                        },
                    new PalletAuditStatus
                        {
                            Value = "I",
                            Description = "catalogs.palletAuditStatus.completedWithDiscrepancies"
                        }
                };
        }
    }
}
