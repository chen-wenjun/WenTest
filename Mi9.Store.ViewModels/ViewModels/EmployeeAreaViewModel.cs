using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EmployeeAreaViewModel
    {
        [JsonProperty(PropertyName = "areaId")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } // C,D,O,S

        [JsonProperty(PropertyName = "statusDate")]
        public DateTime StatusDate { get; set; }

        [JsonProperty(PropertyName = "createDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty(PropertyName = "originalAreaId")]
        public int? OriginalAreaId { get; set; }

        [JsonProperty(PropertyName = "departmentInArea")]
        public int? DepartmentInArea { get; set; }

        [JsonProperty(PropertyName = "employeeId")]
        public int? EmployeeId { get; set; }
    }
}
