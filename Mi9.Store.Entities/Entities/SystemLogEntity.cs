using System;

namespace Mi9.Store.Entities.Entities
{
    public class SystemLogEntity
    {
       public SystemLogEntity()
        {
            this.ProgName = string.Empty;
            this.EmployeeId = 0;
            this.LogMessage = string.Empty;
            this.Category = string.Empty;
            this.LogType = 2;
            this.LogDate = DateTime.Now.Date;
            this.LogTime = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss")).TimeOfDay;
        }

        public int AutoIncrement { get; set; }

        public DateTime LogDate { get; set; }

        public TimeSpan LogTime { get; set; }

        public byte LogType { get; set; }

        public string ProgName { get; set; }

        public int EmployeeId { get; set; }

        public string LogMessage { get; set; }

        public string Category { get; set; }
    }
}
