using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ManagerCredentials
    {
        [JsonProperty("managerPayroll")]
        public string ManagerPayroll { get; set; }
        [JsonProperty("managerPassword")]
        public string ManagerPassword { get; set; }
    }
}
