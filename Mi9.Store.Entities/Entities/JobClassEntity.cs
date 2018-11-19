using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class JobClassEntity
    {
        public int JobClassId { get; set; }

        public string JobDescription { get; set; }

        public byte JobCode { get; set; }

        public string JobType { get; set; }

        public virtual ICollection<EmployeeEntity> Employees { get; set; }
    }
}