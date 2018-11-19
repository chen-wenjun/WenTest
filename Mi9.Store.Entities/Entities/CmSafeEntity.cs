using System;

namespace Mi9.Store.Entities.Entities
{
    public class CmSafeEntity
    {
        public int TenderId { get; set; }
        public int CurrencyId { get; set; }
        public int EmployeeNo { get; set; }
        public DateTime? SetupDate { get; set; }
        public decimal TenderAmount { get; set; }
        public int TenderCount { get; set; }
    }
}
