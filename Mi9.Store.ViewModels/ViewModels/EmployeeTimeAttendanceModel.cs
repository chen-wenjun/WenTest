using System;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class EmployeeTimeAttendanceModel
    {
        public long AttendanceId { set; get; }

        public DateTime AttendanceDate { set; get; }

        public TimeSpan ClockIn { set; get; }

        public TimeSpan? ClockOut { set; get; }

        public bool IsManualRecord { get; set; }

        public int EmployeeNo { set; get; }

        public EmployeeEntity Employee { set; get; }
    }
}
