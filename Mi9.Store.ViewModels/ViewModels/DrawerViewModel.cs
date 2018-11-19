using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DrawerViewModel
    {
        [JsonProperty(PropertyName = "drawer")]
        public byte Drawer { get; set; }

        [JsonProperty(PropertyName = "issuedDate")]
        public DateTime IssuedDate { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
