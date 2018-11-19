using System;

namespace Mi9.Store.Entities.Entities
{
    public class GeneratedScheduleDayEntity
    {
        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public int? ReasonId { get; set; }

        public bool IsTimeOff { get; set; }

        public virtual ReasonTypeEntity ReasonType { get; set; }

        public virtual EmployeeEntity Employee { get; set; }
    }
}