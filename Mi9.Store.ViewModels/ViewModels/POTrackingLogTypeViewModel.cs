﻿using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingLogTypeViewModel
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
