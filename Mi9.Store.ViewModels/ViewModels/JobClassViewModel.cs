using System.Globalization;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JobClassViewModel
    {
        [JsonProperty(PropertyName = "jobTitleId")]
        public int JobClassId { get; set; }

        [JsonProperty(PropertyName = "jobCode")]
        public byte JobCode { get; set; }

        [JsonProperty(PropertyName = "jobTitle")]
        public string JobDescription { get; set; }

        [JsonProperty(PropertyName = "jobType")]
        public string JobType { get; set; }
        
        [JsonProperty(PropertyName = "jobName")]
        public string JobName
        {
            get
            {
                return JobClassId.ToString(CultureInfo.InvariantCulture) + " " + JobDescription;
            }
        }
    }
}