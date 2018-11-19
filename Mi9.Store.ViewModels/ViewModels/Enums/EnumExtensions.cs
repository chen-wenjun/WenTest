using System;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public static class EnumExtensions
    {
        //TODO: May be char?
        public static T ToEnum<T>(string @string)
        {
            if (string.IsNullOrEmpty(@string))
            {
                throw new ArgumentException("Argument null or empty");
            }

            if (@string.Length > 1)
            {
                throw new ArgumentException("Argument length greater than one");
            }

            return (T)Enum.ToObject(typeof(T), @string[0]);
        }
    }
}