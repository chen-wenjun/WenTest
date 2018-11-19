using System;
using System.Collections.Generic;
using MI9.HDM.Store.BackOffice.Core;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class RequestAbsencePutViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "concept")]
        public string Concept { get; set; }

        [JsonProperty(PropertyName = "conceptId")]
        public int ReasonId { get; set; }

        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "jobTitleId")]
        public int DepartmentId { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeStatus { get; set; }

        [JsonProperty(PropertyName = "jobTitle")]
        public string DepartmentName { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "startingDay")]
        public DateTime? StartDate { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "endingDay")]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "days")]
        public int Days { get; set; }

        [JsonProperty(PropertyName = "daysOff")]
        public int DaysOff { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "trainingDay")]
        public DateTime? TrainingDate { get; set; }

        [JsonProperty(PropertyName = "trainingHours")]
        public ICollection<bool?> TrainingHours { get; set; } 
    }
}