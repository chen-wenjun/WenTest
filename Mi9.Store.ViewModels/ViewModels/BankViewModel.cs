using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class BankViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string BankCode { get; set; }

        [JsonProperty(PropertyName = "bankId")]
        public int BankId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "createDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty(PropertyName = "lastUpdate")]
        public DateTime? LastUpdate { get; set; }

        [JsonProperty(PropertyName = "inactiveDate")]
        public DateTime? InactiveDate { get; set; }

        [JsonProperty(PropertyName = "createUser")]
        public string CreateUser { get; set; }

        [JsonProperty(PropertyName = "lastUpdateUser")]
        public string LastUpdateUser { get; set; }

        [JsonProperty(PropertyName = "inactiveUser")]
        public string InactiveUser { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string BankName { get; set; }
    }
}
