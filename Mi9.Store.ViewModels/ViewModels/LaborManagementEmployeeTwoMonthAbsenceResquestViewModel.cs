using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LaborManagementEmployeeTwoMonthAbsenceResquestViewModel
    {
        [JsonProperty(PropertyName = "payrollId")]
        public string PayrollId { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
    }
}
