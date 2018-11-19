using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CustomerServiceDemandViewModel
    {
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime DemandDate { get; set; }

        public int JobClass { get; set; }

        public short[] Hours { get; set; }
    }
}