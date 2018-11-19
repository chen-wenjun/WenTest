using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class IncidentTypeEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<WeekDayEntity> Days { get; set; }
    }
}
