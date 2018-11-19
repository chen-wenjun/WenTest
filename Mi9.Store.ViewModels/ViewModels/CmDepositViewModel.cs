using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDepositViewModel
    {
        [JsonProperty(PropertyName = "depositNumber")]
        public long DepositNumber { get; set; }

        [JsonProperty(PropertyName = "referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonProperty(PropertyName = "depositDate")]
        public DateTime? DepositDate { get; set; }

        [JsonProperty(PropertyName = "uploadedDate")]
        public DateTime? UploadedDate { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "employeeId")]
        public string EmployeeNo { get; set; }

        [JsonProperty(PropertyName = "employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public virtual IEnumerable<CmDepositDetailViewModel> Tenders { get; set; }

        [JsonIgnore]
        public bool NotShouldSerialize { get; set; }

        public bool ShouldSerializeTenders()
        {
            if (!NotShouldSerialize)
                return true;
            return false;
        }
    }
}
