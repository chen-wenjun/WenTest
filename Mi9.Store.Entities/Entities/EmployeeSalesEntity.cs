using System;

namespace Mi9.Store.Entities.Entities
{
    public class EmployeeSalesEntity
    {
        public EmployeeSalesEntity()
        {
            SalesActive = "N";
            Divide = false;
            IssueDate = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            StatusDate = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
        }

        public long Id { get; set; }

        public string SalesActive { get; set; } // "A,N,T,X"

        public bool Divide { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime StatusDate { get; set; }

        public byte? AreaId { get; set; }

        public short? AreaPercent { get; set; }

        public short? DepartmentId { get; set; }

        public short? DepartmentPercent { get; set; }

        public virtual int EmployeeNo { get; set; }

        public virtual EmployeeEntity Employee { get; set; }
    }
}
