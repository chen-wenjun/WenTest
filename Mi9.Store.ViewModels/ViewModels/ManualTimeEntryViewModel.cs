using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mi9.Store.ViewModels.ViewModels
{
    /// <summary>
    /// The manual time entry view model.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ManualTimeEntryViewModel : TimeIntervalsViewModel
    {
        /// <summary>
        /// Gets or sets the buton type.
        /// </summary>
        [JsonProperty(PropertyName = "buttonType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ManualTimeEntryButonTypes ButonType { get; set; }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <param name="validationContext">
        /// The validation context.
        /// </param>
        /// <returns>
        /// The set of validation result.
        /// </returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Intervals != null && Intervals.Any())
            {
                var currentDayStart = DateTime.Now.Date;
                var clientTime = DateTime.Now.TimeOfDay;

                var firstIntervalOfCurrentDay =
                    Intervals.Where(t => t.AttendanceDate.Date == currentDayStart)
                        .OrderBy(t => t.ClockIn)
                        .FirstOrDefault();
                if (firstIntervalOfCurrentDay != null
                    && (clientTime - firstIntervalOfCurrentDay.ClockIn).TotalHours > TotalHoursLimit)
                {
                    yield return new ValidationResult(ValidationMessages.TotalHoursExceedLimit);
                }
            }

            foreach (var baseError in base.Validate(validationContext))
            {
                yield return baseError;
            }
        }
    }
}
