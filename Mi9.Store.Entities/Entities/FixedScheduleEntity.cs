namespace Mi9.Store.Entities.Entities
{
    public class FixedScheduleEntity
    {
        public int EmployeeId { get; set; }

        public byte DayOfWeek { get; set; }

        public byte HourOfDay { get; set; }

        public decimal? HourPart { get; set; }

        public int? ReasonId { get; set; }

        public bool IsOverNight { get; set; }

        public virtual ReasonTypeEntity ReasonType { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        //TODO: Define in the ViewModel layer
        //[NotMapped]
        //public int[] DaysOff { get; set; }
    }
}