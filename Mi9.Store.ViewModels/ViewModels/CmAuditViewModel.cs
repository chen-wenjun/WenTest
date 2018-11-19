using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmAuditViewModel
    {
        [JsonProperty(PropertyName = "auditReason")]
        public string AuditReason { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public virtual IEnumerable<CmMaintenanceDetailViewModel> Tenders { get; set; }
    }
}
