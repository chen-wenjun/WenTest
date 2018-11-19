using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class ReasonTypeEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Color { get; set; }

        public virtual ICollection<FixedScheduleEntity> FixedSchedules { get; set; }

        public virtual ICollection<GeneratedScheduleEntity> GeneratedSchedules { get; set; }

        public virtual ICollection<GeneratedScheduleDayEntity> GeneratedScheduleDays { get; set; } 

        public virtual ICollection<RequestAbsenceEntity> RequestAbsences { get; set; }
    }
}