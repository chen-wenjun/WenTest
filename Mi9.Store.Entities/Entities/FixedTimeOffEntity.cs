namespace Mi9.Store.Entities.Entities
{
    public class FixedTimeOffEntity
    {
        public int EmployeeId { get; set; }

        public byte DayOfWeek { get; set; }

        public bool IsTimeOff { get; set; }

        public virtual EmployeeEntity Employee { get; set; }
    }
}