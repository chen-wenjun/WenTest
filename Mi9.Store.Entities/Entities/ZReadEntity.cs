using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class ZReadEntity
    {
        public short RegisterId { get; set; }

        public int TranNumber { get; set; }

        public DateTime TranDate { get; set; }

        public int EmployeeNo { get; set; }

        public string RecStatus { get; set; }

        public byte OperatMode { get; set; }

        public byte CollectPer { get; set; }

        public byte TypeOfSale { get; set; }

        public bool ZReadType { get; set; }

        public decimal ZTaxAmt { get; set; }

        public decimal ZDiscountAmt { get; set; }

        public decimal ZCashAmt { get; set; }

        public decimal ZMdseAmt { get; set; }

        public decimal ZNonMdseAmt { get; set; }

        public bool Posted { get; set; }

        public byte Drawer { get; set; }

        public decimal ZDeposits { get; set; }

        public decimal ZPayments { get; set; }

        public decimal ZPickUps { get; set; }

        public decimal ZLoans { get; set; }

        public virtual List<ZReadTenderTypeEntity> ZReadTenders { get; set; }
    }
}