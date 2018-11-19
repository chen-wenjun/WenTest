using System;

namespace Mi9.Store.Entities.Entities
{
    public class WeekDayEntity
    {
        public DateTime Date { get; set; }

        public bool IsTimeOff { get; set; }

        public int? IncidentId { get; set; }

        public virtual IncidentTypeEntity IncidentType { get; set; }

        public virtual int EmployeeId { get; set; }

        public virtual EmployeeEntity Employee { get; set; }
    }
}