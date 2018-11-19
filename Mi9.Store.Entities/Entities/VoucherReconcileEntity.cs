using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class VoucherReconcileEntity
    {
        public int VoucherReconcileId { get; set; }

        public DateTime Date { get; set; }

        public int TenderId { get; set; }

        public virtual TenderEntity Tender { get; set; }

        public int EmployeeNo { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        public virtual List<VoucherReconcileDetailsEntity> Details { get; set; }
    }

    public class VoucherReconcileDetailsEntity
    {
        public int VoucherReconcileDetailId { get; set; }

        public int DenominationId { get; set; }

        public DenominationEntity Denomination { get; set; }

        public int Count { get; set; }

        public decimal TotalPrice { get; set; }

        public int VoucherReconcileId { get; set; }

        public virtual VoucherReconcileEntity VoucherReconcile { get; set; } 
    }
}