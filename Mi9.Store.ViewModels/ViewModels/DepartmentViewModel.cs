using System.Globalization;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DepartmentViewModel
    {
        [JsonProperty(PropertyName = "departmentId")]
        public short DepartmentId { get; set; }

        
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get
            {
                return DepartmentId.ToString(CultureInfo.InvariantCulture) + " " + this.Description;
            }
        }
    }
}
