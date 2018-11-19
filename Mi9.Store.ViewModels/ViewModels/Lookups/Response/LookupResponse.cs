using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Response
{
    public class LookupResponse : ILookupResponse
    {
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
        [JsonProperty(PropertyName = "items")]
        public IEnumerable<Object> Items { get; set; }
    }
}