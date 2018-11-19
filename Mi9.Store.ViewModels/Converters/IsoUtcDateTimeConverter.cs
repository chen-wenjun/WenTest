using System;
using System.Collections.Generic;
using System.Web.SessionState;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mi9.Store.ViewModels.Converters
{
    /// <summary>
    /// The ISO UTC date time converter.
    /// </summary>
    public class IsoUtcDateTimeConverter : IsoDateTimeConverter, IRequiresSessionState
    {
        /// <summary>
        /// The write JSON.
        /// </summary>
        /// <param name="writer"> The writer. </param>
        /// <param name="value"> The value. </param>
        /// <param name="serializer"> The serializer. </param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var vals = value as ICollection<DateTime>;
            if (vals != null)
            {
                writer.WriteStartArray();
                foreach (var val in vals)
                {
                    var utcDateTime = val.ToUniversalTime();

                    writer.WriteValue(utcDateTime);
                }

                writer.WriteEndArray();
            }

            if (value is DateTime)
            {
                var utcDateTime = ((DateTime)value).ToUniversalTime();

                writer.WriteValue(utcDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            }
        }

        /// <summary>
        /// The read JSON.
        /// </summary>
        /// <param name="reader"> The reader. </param>
        /// <param name="objectType"> The object type. </param>
        /// <param name="existingValue"> The existing value. </param>
        /// <param name="serializer"> The serializer. </param>
        /// <returns> The <see cref="object"/>. </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            DateTime date;

            // TODO: need to figure out is this statement needed here
            if (objectType == typeof(ICollection<DateTime>))
            {
                return serializer.Deserialize<ICollection<DateTime>>(reader);
            }

            if (reader.Value is DateTime && ((DateTime)reader.Value) != DateTime.MinValue)
            {
                date = (DateTime)reader.Value;

                var result = date.ToLocalTime();
                return result;
            }

            if (reader.Value == null)
            {
                return null;
            }

            if (DateTime.TryParse(reader.Value.ToString(), out date) && date != DateTime.MinValue)
            {
                var result = date.ToLocalTime();
                return result;
            }

            return reader.Value;
        }
    }
}