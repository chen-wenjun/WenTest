using System;
using System.Linq;
using Newtonsoft.Json;
using Mi9.Store.Localization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CorrectTimeViewModel : TimeIntervalsViewModel
    {
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (this.Intervals != null && this.Intervals.Any())
            {
                if (this.Intervals.Count(t => t.IsOvernight) > 1)
                {
                    yield return new ValidationResult(ValidationMessages.MultipleOvernightIntervals);
                }

                if (this.Intervals.Count > 1)
                {
                    var firstInterval = this.Intervals.First();
                    var lastInterval = this.Intervals.Last();

                    if (!lastInterval.IsOpenInterval
                        && firstInterval.ClockIn < lastInterval.ClockOut
                        // ReSharper disable once PossibleInvalidOperationException
                        && (lastInterval.ClockOut.Value - firstInterval.ClockIn).TotalHours > this.TotalHoursLimit)
                    {
                        yield return new ValidationResult(ValidationMessages.TotalHoursExceedLimit);
                    }

                    if (!lastInterval.IsOpenInterval
                       && firstInterval.ClockIn > lastInterval.ClockOut
                        // ReSharper disable once PossibleInvalidOperationException
                       && (new TimeSpan(23, 59, 59) - firstInterval.ClockIn + lastInterval.ClockOut.Value).TotalHours > this.TotalHoursLimit)
                    {
                        yield return new ValidationResult(ValidationMessages.TotalHoursExceedLimit);
                    }
                }

                var currentTime = DateTime.Now.TimeOfDay;
                var currentDate = DateTime.Now.Date;
                if (this.Intervals.Any(t => t.ClockIn > currentTime && t.AttendanceDate.Date >= currentDate) || 
                    this.Intervals.Any(t => t.ClockOut.HasValue && t.ClockOut.Value > currentTime && t.AttendanceDate.Date >= currentDate))
                {
                    yield return new ValidationResult(ValidationMessages.DateInFuture);
                }

                if (this.Intervals.Any(t => t.IsOvernight && t.ClockOut.HasValue && t.AttendanceDate.Date >= currentDate))
                {
                    yield return new ValidationResult("You can not set the future date for overnight.");
                }

                var sortedIntervals = this.Intervals
                    .Where(t => !t.IsOvernight)
                    .OrderBy(t => t.ClockIn)
                    .ToList();

                for (int i = 1; i < sortedIntervals.Count; i++)
                {
                    var currentInterval = sortedIntervals[i];
                    var lastInterval = sortedIntervals[i - 1];
                    var lastClockOut = lastInterval.ClockOut;
                    var currentClockIn = currentInterval.ClockIn;

                    if (!currentInterval.IsOpenInterval
                        && !lastInterval.IsOpenInterval
                        && currentClockIn < lastClockOut)
                    {
                        yield return new ValidationResult(ValidationMessages.OverlappedIntervals);
                    }
                }

                if (this.Intervals.Any(t => t.IsOvernight))
                {
                    var overNightInterval = this.Intervals.First(t => t.IsOvernight);

                    foreach (var interval in sortedIntervals)
                    {
                        if (interval.ClockIn >= overNightInterval.ClockIn
                            || (interval.ClockOut.HasValue
                            && interval.ClockOut > overNightInterval.ClockIn))
                        {
                            yield return new ValidationResult(ValidationMessages.OverlappedIntervals);
                        }
                    }
                }

                for (int i = 1; i < this.Intervals.Count; i++)
                {
                    var currentInterval = this.Intervals[i];
                    var lastInterval = this.Intervals[i - 1];
                    if (!lastInterval.IsOvernight && currentInterval.ClockIn <= lastInterval.ClockIn)
                    {
                        yield return new ValidationResult(ValidationMessages.IntervalEarlyThenLastInList);
                    }

                    if (lastInterval.IsOpenInterval)
                    {
                        yield return new ValidationResult(ValidationMessages.OpenIntervalIsLastInList);
                    }
                }
            }

            foreach (var baseError in base.Validate(validationContext))
            {
                yield return baseError;
            }
        }
    }
}