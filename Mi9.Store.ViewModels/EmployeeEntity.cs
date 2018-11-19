using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class EmployeeEntity : IAuditableEntity
    {
        public int EmployeeNo { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string TABadge { get; set; }

        public int? JobClassId { get; set; }

        public byte Status { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; } 

        public string Phone { get; set; } 

        public string Initials { get; set; } 

        public string SocialSecurityNumber { get; set; }

        public byte SecurityNumber { get; set; }

        public bool IsSupervisor { get; set; }

        public decimal? CashInDrawer { get; set; }

        public bool NewContract { get; set; }

        public string AddressLine1 { get; set; } 

        public string AddressLine2 { get; set; }

        public string PayrollId { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? TermDate { get; set; }

        public Int16? EmpLocation { get; set; }

        public string Position { get; set; }

        public string JobTitle { get; set; }
        
        public DateTime? TermAcceptedOn { get; set; }

        public bool DrawerOpen__1 { get; set; }

        public bool DrawerOpen__2 { get; set; }

        public bool DrawerOpen__3 { get; set; }

        //public virtual ICollection<EmployeeSalesEntity> EmployeeSales { get; set; }

        //public virtual ICollection<EmployeeAreaEntity> EmployeeAreas { get; set; }

        //public virtual JobClassEntity JobClass { get; set; }

        //public virtual ICollection<EmployeeTimeAttendanceEntity> TimeAttendances { get; set; }

        //public virtual ICollection<WithdrawalEntity> Withdrawals { get; set; }

        //public virtual ICollection<DepositAggregationEntity> DepositAggregations { get; set; }

        //public virtual ICollection<VoucherReconcileEntity> VoucherReconciles { get; set; }

        //public virtual ICollection<WeekDayEntity> Days { get; set; }

        //public virtual ICollection<FixedTimeOffEntity> TimeOffs { get; set; }

        //public virtual ICollection<FixedScheduleEntity> FixedSchedule { get; set; }

        //public virtual ICollection<GeneratedScheduleEntity> GeneratedSchedules { get; set; }

        //public virtual ICollection<GeneratedScheduleDayEntity> GeneratedScheduleDays { get; set; } 

        //public virtual ICollection<RequestAbsenceEntity> RequestAbsences { get; set; }

        //public virtual ICollection<PurchaseOrderEntity> PurchaseOrders { get; set; }
        
        //public virtual ICollection<ShipmentEntity> CreatedShipments { get; set; }

        //public virtual ICollection<ShipmentEntity> UpdatedShipments { get; set; }

        //public virtual ICollection<ShipmentEntity> ConfirmedShipments { get; set; }

        //public virtual ICollection<PalletEntity> CreatedPallets { get; set; }

        //public virtual ICollection<PalletEntity> UpdatedPallets { get; set; }

        //public virtual ICollection<PalletEntity> ConfirmedPallets { get; set; }
    }
}