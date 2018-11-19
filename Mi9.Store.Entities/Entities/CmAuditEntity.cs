using System;

namespace Mi9.Store.Entities.Entities
{
    public class CmAuditEntity
    {
        public int Id { get; set; }
        public int TenderId { get; set; }
        public int CurrencyId { get; set; }
        public int EmployeeNo { get; set; }
        public DateTime AuditDate { get; set; }
        public string AuditReason { get; set; }
        public decimal TenderAmount { get; set; }
        public int TenderCount { get; set; }
        public decimal Rate { get; set; }
        public decimal PrevSafeAmount { get; set; }
        public int PrevSafeCount { get; set; }
    }
}
