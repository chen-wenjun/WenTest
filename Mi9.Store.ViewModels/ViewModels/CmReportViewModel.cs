using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmReportViewModel
    {
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "store")]
        public CmStoreViewModel Store { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public CmOwnerViewModel Owner { get; set; }

        [JsonProperty(PropertyName = "drawer")]
        public DrawerViewModel Drawer { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public ICollection<CmDrawerTenderViewModel> Tenders { get; set; }
    }
}
