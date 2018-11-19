using System;
using System.Collections.Generic;
using System.Globalization;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WeekViewModel
    {
        /// <summary>
        /// The week start date.
        /// </summary>
        private DateTime weekStartDate;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the week start date.
        /// </summary>
        [JsonProperty(PropertyName = "weekStart")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime WeekStartDate
        {
            get
            {
                return weekStartDate.Date;
            }

            set
            {
                weekStartDate = value;
            }
        }

        /// <summary>
        /// Gets the week end date.
        /// </summary>
        [JsonProperty(PropertyName = "weekEnd")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime WeekEndDate
        {
            get
            {
                return WeekStartDate.AddDays(6).Date;
            }
        }

        /// <summary>
        /// Gets the week range.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string WeekRange
        {
            get
            {
                return WeekStartDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
                    + " - "
                    + WeekEndDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Gets the week list.
        /// </summary>
        [JsonProperty(PropertyName = "weekList")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public List<DateTime> WeekList
        {
            get
            {
                return this.GettingWeekArray();
            }
        }

        /// <summary>
        /// The getting week array.
        /// </summary>
        /// <returns>
        /// The result of weeks.
        /// </returns>
        private List<DateTime> GettingWeekArray()
        {
            var dateList = new List<DateTime>();
            for (var i = WeekStartDate; i <= WeekEndDate; i = i.AddDays(1))
            {
                dateList.Add(i.Date);
            }

            return dateList;
        }
    }
}