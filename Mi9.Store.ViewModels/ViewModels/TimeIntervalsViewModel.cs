using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using Newtonsoft.Json;
using Mi9.Store.Localization;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class TimeIntervalsViewModel : IValidatableObject
    {
        protected readonly int TotalHoursLimit;

        protected TimeIntervalsViewModel()
        {
            this.TotalHoursLimit = int.Parse(ConfigurationManager.AppSettings["TimeAndAttendance:TotalHoursLimit"]);
        }

        [JsonProperty(PropertyName = "employeeId")]
        public int EmployeeNo { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime AttendanceDate { get; set; }

        [JsonProperty(PropertyName = "intervals")]
        public List<TimeIntervalViewModel> Intervals { get; set; }

        [JsonProperty(PropertyName = "incidentType")]
        public IncidentTypeViewModel IncidentType { get; set; }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!(this.EmployeeNo > 0))
            {
                yield return new ValidationResult(ValidationMessages.EmployeeNoIncorrect);
            }

            if (this.AttendanceDate == DateTime.MinValue)
            {
                yield return new ValidationResult(ValidationMessages.AttendanceDateMinValue);
            }

            if (this.Intervals == null)
            {
                yield return new ValidationResult(ValidationMessages.IntervalsNull);
            }

            if (this.Intervals != null && this.Intervals.Any())
            {
                if (this.Intervals.Count(t => t.IsOpenInterval) > 1)
                {
                    yield return new ValidationResult(ValidationMessages.MultipleOpenInterval);
                }

                if (this.Intervals.Any(t => t.IsEmptyInterval))
                {
                    yield return new ValidationResult(ValidationMessages.IntervalIsEmpty);
                }
            }
        }
    }
}
