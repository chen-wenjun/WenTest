using System;

namespace Mi9.Store.Entities.Entities
{
    public class DepositAggregationEntity
    {
        public int AggregationId { get; set; }

        public DateTime Date { get; set; }

        public int EmployeeNo { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        public int? CarrierId { get; set; }

        public virtual TransportCompanyEntity Carrier { get; set; }

        public int? TenderId { get; set; }

        public virtual TenderEntity Tender { get; set; }

        public byte TenderCode { get; set; }

        public virtual TenderTypeEntity TenderType { get; set; }

        public decimal Amount { get; set; }

        public string Comment { get; set; }
    }
}