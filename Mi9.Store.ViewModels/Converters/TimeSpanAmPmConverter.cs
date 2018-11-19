using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.Converters
{
    public class TimeSpanAmPmConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var dateTime = DateTime.ParseExact(reader.Value as string, "h:mm tt", CultureInfo.InvariantCulture);
            return dateTime.TimeOfDay;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var timeSpan = (TimeSpan)value;
            var dtTemp = DateTime.ParseExact(timeSpan.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var strTime = dtTemp.ToString("hh:mm tt");
            strTime=strTime.Replace("a. m.", "AM")
                .Replace("p. m.","PM");
            writer.WriteValue(strTime);
        }
    }
}
