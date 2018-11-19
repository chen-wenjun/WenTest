using System;
using System.Collections.Generic;
//using Mi9.Store.Localization;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TimeIntervalViewModel : IValidatableObject
    {
        /// <summary>
        /// The _clock out.
        /// </summary>
        private TimeSpan? _clockOut;

        /// <summary>
        /// The _clock in.
        /// </summary>
        private TimeSpan _clockIn;

        /// <summary>
        /// Gets or sets a Primary key for this interval
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public long AttendanceId { get; set; }

        /// <summary>
        /// Gets or sets the attendance date.
        /// </summary>
        public virtual DateTime AttendanceDate { get; set; }

        /// <summary>
        /// Gets or sets the clock in.
        /// </summary>
        public virtual TimeSpan ClockIn
        {
            get
            {
                return new TimeSpan(_clockIn.Days, _clockIn.Hours, _clockIn.Minutes, _clockIn.Seconds);
            }

            set
            {
                _clockIn = value;
            }
        }

        /// <summary>
        /// Gets or sets the clock out.
        /// </summary>
        public TimeSpan? ClockOut
        {
            get { return _clockOut.HasValue ? new TimeSpan(_clockOut.Value.Days, _clockOut.Value.Hours, _clockOut.Value.Minutes, _clockOut.Value.Seconds) : default(TimeSpan?); }
            set { _clockOut = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether is manual record.
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool IsManualRecord { get; set; }

        /// <summary>
        /// Gets or sets the employee no.
        /// </summary>
        public int EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public EmployeeViewModel Employee { get; set; }

        /// <summary>
        /// Gets the total hours.
        /// </summary>
        public virtual decimal TotalHours
        {
            get
            {
                return GetTotalHours();
            }
        }

        /// <summary>
        /// Gets a value indicating whether is overnight.
        /// </summary>
        public bool IsOvernight
        {
            get
            {
                return ClockIn > ClockOut;
            }
        }

        /// <summary>
        /// Gets a value indicating whether is open interval.
        /// </summary>
        public bool IsOpenInterval
        {
            get
            {
                return !ClockOut.HasValue;
            }
        }

        /// <summary>
        /// Gets a value indicating whether is empty interval.
        /// </summary>
        public bool IsEmptyInterval
        {
            get
            {
                return ClockIn == ClockOut;
            }
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <param name="validationContext">
        /// The validation context.
        /// </param>
        /// <returns>
        /// The enumerable of <see cref="ValidationResult"/>.
        /// </returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //if (!(EmployeeNo > 0))
            //{
            //    yield return new ValidationResult(ValidationMessages.EmployeeNoIncorrect);
            //}

            //if (AttendanceDate.Date > DateTime.Now.Date)
            //{
            //    yield return new ValidationResult(ValidationMessages.AttendanceDateInFuture);
            //}

            //if (Employee != null && (Employee.EmployeeNo != EmployeeNo))
            //{
            //    yield return new ValidationResult(ValidationMessages.EmployeeNumberNotConsistent);
            //}

            //if (TotalHours < 0 || TotalHours > 16)
            //{
            //    yield return new ValidationResult(ValidationMessages.TotalHoursExceedLimit);
            //}

            return null;
        }

        /// <summary>
        /// The get total hours.
        /// </summary>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        private decimal GetTotalHours()
        {
            decimal totalHours;
            var clockin = ClockIn;
            var clockout = ClockOut;

            if (!clockout.HasValue)
            {
                return 0;
            }

            if (IsOvernight)
            {
                totalHours = (decimal)(new TimeSpan(24, 0, 0) - clockin + clockout).Value.TotalHours;
            }
            else
            {
                totalHours = (decimal)(clockout - clockin).Value.TotalHours;
            }

            return totalHours;
        }
    }
}