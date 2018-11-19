using System;

namespace Mi9.Store.Entities.Entities
{
    public class CheckEntity : IAuditableEntity
    {
        public DateTime DepositDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public DateTime TranDate { get; set; }

        public short RegisterId { get; set; }

        public int TranNumber { get; set; }

        public int EmployeeNo { get; set; }

        public decimal TenderAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public string MiscNumber { get; set; }

        public string SecMiscNo { get; set; }

        public string ThirdMiscNo { get; set; }

        public byte TypeOfSale { get; set; }

        public bool PostVoid { get; set; }

        public string PostVTran { get; set; }

        public string Comments { get; set; }

        public bool Deposited { get; set; }

        public int LastMntEmp { get; set; }

        public DateTime? LastMntDate { get; set; }

        public decimal TranTotal { get; set; }

        public decimal TaxableSales { get; set; }

        public decimal TxbleNonMdse { get; set; }

        public string FourthMisc { get; set; }

        public string FifthMisc { get; set; }

        public string Protected { get; set; }

        public string Bank { get; set; }

        public byte PaymentForm { get; set; }

        public string BankReference { get; set; }

        public string Reason { get; set; }

        public string NewAuthCheckPlus { get; set; }

        public virtual EJournalItemEntity EJournalItem { get; set; }
    }
}