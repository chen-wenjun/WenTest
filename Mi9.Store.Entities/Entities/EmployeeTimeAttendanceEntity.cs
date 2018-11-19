using System;

namespace Mi9.Store.Entities.Entities
{
    public class EmployeeTimeAttendanceEntity : IAuditableEntity
    {
        public long AttendanceId { get; set; }

        public DateTime AttendanceDate { get; set; }

        public TimeSpan ClockIn { get; set; }

        public TimeSpan? ClockOut { get; set; }

        public bool IsManualRecord { get; set; }

        public int EmployeeNo { get; set; }

        public string TABadge { get; set; }

        public EmployeeEntity Employee { get; set; }
    }
}