namespace Mi9.Store.ViewModels.ViewModels
{
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization.OptIn)]
    public class StoreEmployeeViewModel
    {
        [JsonProperty(PropertyName = "employeeId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}