namespace Mi9.Store.ViewModels.Converters
{
    public class DateUtils
    {
        public static byte DayOfWeek(string weekDay)
        {
            switch (weekDay.ToUpper())
            {
                case "MONDAY": return 0;
                case "TUESDAY": return 1;
                case "WEDNESDAY": return 2;
                case "THURSDAY": return 3;
                case "FRIDAY": return 4;
                case "SATURDAY": return 5;
                case "SUNDAY": return 6;
                default:
                    return 0;
            }
        }
    }
}