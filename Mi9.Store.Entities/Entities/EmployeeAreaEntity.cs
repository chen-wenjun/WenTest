using System;

namespace Mi9.Store.Entities.Entities
{
    public class EmployeeAreaEntity
    {
        public EmployeeAreaEntity()
        {
            this.Type = "O";
            this.Description = string.Empty;
            this.StatusDate = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            this.CreateDate = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
        }

        public byte Id { get; set; }

        public string Description { get; set; }

        public string Type { get; set; } // C,D,O,S

        public DateTime StatusDate { get; set; }

        public DateTime CreateDate { get; set; }

        public byte OriginalAreaId { get; set; }

        public short? DepartmentInArea1 { get; set; }

        public short? DepartmentInArea2 { get; set; }

        public short? DepartmentInArea3 { get; set; }

        public short? DepartmentInArea4 { get; set; }

        public short? DepartmentInArea5 { get; set; }

        public short? DepartmentInArea6 { get; set; }

        public short? DepartmentInArea7 { get; set; }

        public short? DepartmentInArea8 { get; set; }

        public short? DepartmentInArea9 { get; set; }

        public short? DepartmentInArea10 { get; set; }

        public short? DepartmentInArea11 { get; set; }

        public short? DepartmentInArea12 { get; set; }

        public short? DepartmentInArea13 { get; set; }

        public short? DepartmentInArea14 { get; set; }

        public short? DepartmentInArea15 { get; set; }

        public short? DepartmentInArea16 { get; set; }

        public short? DepartmentInArea17 { get; set; }

        public short? DepartmentInArea18 { get; set; }

        public short? DepartmentInArea19 { get; set; }

        public short? DepartmentInArea20 { get; set; }

        public virtual int? EmployeeId { get; set; }

        public virtual EmployeeEntity Employee { get; set; }
    }
}
