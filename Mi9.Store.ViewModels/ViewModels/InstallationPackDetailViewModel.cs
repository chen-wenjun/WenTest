using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallationPackDetailViewModel
    {
        [JsonProperty("packId")]
        public int InstallationPackId { get; set; }

        [JsonProperty("serviceSequence")]
        public short ServiceSequence { get; set; }

        [JsonProperty("id")]
        public int ServiceId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cost")]
        public decimal InstCost { get; set; }

        [JsonProperty("price")]
        public decimal InstPrice { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("uom")]
        public string Uom { get; set; }

        [JsonProperty(PropertyName = "departmentId")]
        public short DepartmentId { get; set; }

        [JsonProperty(PropertyName = "classId")]
        public short ClassId { get; set; }
   }
}