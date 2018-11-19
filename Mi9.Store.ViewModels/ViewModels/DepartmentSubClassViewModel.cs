using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DepartmentSubClassViewModel 
    {
        [JsonProperty(PropertyName = "departmentId")]
        public short DepartmentId { get; set; }

        [JsonProperty(PropertyName = "classId")]
        public short ClassId { get; set; }

        [JsonProperty(PropertyName = "subClassId")]
        public short SubClassId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}