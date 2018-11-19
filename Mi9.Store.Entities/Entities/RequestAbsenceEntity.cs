using System;

namespace Mi9.Store.Entities.Entities
{
    public class RequestAbsenceEntity
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int ReasonId { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool Applied { get; set; }

        virtual public EmployeeEntity Employee { get; set; }

        virtual public ReasonTypeEntity ReasonType { get; set; }
    }
}