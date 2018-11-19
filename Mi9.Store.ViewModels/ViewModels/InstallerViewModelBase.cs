using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallerViewModelBase
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime CreateDate { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public decimal Ranking { get; set; }

        [JsonProperty(PropertyName = "status")]
        public InstallerStatusViewModel Status { get; set; }

        [JsonProperty(PropertyName = "taxExemptNo")]
        public string TaxExemptNo { get; set; }

        [JsonProperty(PropertyName = "addr1")]
        public string Addr1 { get; set; }

        [JsonProperty(PropertyName = "addr2")]
        public string Addr2 { get; set; }

        [JsonProperty(PropertyName = "addr3")]
        public string Addr3 { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "fullAddress")]
        public string FullAddress
        {
            get { return (string.IsNullOrEmpty(Addr1) ? "" : Addr1) + (string.IsNullOrEmpty(Addr2) ? "" : " " + Addr2) + (string.IsNullOrEmpty(Addr3) ? "" : " " + Addr3) + (string.IsNullOrEmpty(City) ? "" : " " + City) + (string.IsNullOrEmpty(State) ? "" : " " + State) + (string.IsNullOrEmpty(Zip) ? "" : " " + Zip); }
        }
    }
}