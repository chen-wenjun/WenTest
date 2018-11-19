using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class TenderTypeEntity
    {
        public byte TenderCode { get; set; }

        public string Description { get; set; }

        public byte MediaType { get; set; }

        public decimal Rate { get; set; }

        public DateTime LastUpdate { get; set; }

        public bool SafeTender { get; set; }

        public TimeSpan LastTime { get; set; }

        public bool IsTransportable { get; set; }

        public bool IsCash { get; set; }

        public bool IsFormOfPayment { get; set; }

        public string FormOfPaymentName { get; set; }

        public virtual ICollection<TenderEntity> Tenders { get; set; }

        public virtual ICollection<DenominationEntity> Denominations { get; set; }

        public virtual ICollection<DepositAggregationEntity> DepositAggregations { get; set; }
    }
}