using System;
using System.ComponentModel;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static string GetDescriptionToLowerString(Enum value)
        {
            return GetDescription(value).ToLower();
        }

        public static string GetDescriptionToUpperString(Enum value)
        {
            return GetDescription(value).ToUpper();
        }

        public static string GetValueToLowerString(Enum value)
        {
            return value.ToString().ToLower();
        }

        public static string GetValueToUpperString(Enum value)
        {
            return value.ToString().ToUpper();
        }
    }
}
