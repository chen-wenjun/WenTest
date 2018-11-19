using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class AuditDialogViewModel
    {
        
        [JsonProperty(PropertyName = "items")]
        public List<AuditDialogItemViewModel> Items { get; set; }

        public AuditDialogViewModel()
        {
            Items = new List<AuditDialogItemViewModel>();
        }
    }
}