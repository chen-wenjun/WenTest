using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class StoreViewModel
    {
        [JsonProperty(PropertyName = "type")]
        public bool StoreType { get; set; }

        [JsonProperty(PropertyName = "id")]
        public short StoreNumber { get; set; }

        public byte? Division { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string StoreName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Phone { get; set; }

        public string ManagerName { get; set; }

        public string Country { get; set; }

        public string TaxCode { get; set; }

        public TaxViewModel Tax { get; set; }

        public DistrictViewModel District { get; set; }

        
        [JsonProperty(PropertyName = "compoundName")]
        public string CompoundName
        {
            get
            {
                return string.Format("{0} {1}", StoreNumber, StoreName);
            }
        }

    }
}
