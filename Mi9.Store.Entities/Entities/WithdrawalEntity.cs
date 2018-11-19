using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class WithdrawalEntity
    {
        public int WithdrawalId { get; set; }

        public DateTime Date { get; set; }

        public short? PartialNumber { get; set; }

        public string Status { get; set; }

        public string BalanceStatus { get; set; }

        public string DocumentType { get; set; }

        public string Comment { get; set; }

        public int EmployeeNo { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        public virtual ICollection<WithdrawalDenominationEntity> WithdrawalDenominations { get; set; }
    }
}