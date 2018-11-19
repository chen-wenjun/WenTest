using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class TenderEntity
    {
        public int TenderId { get; set; }

        public string Key { get; set; }

        public string Description { get; set; }

        public byte TenderCode { get; set; }

        public virtual TenderTypeEntity TenderType { get; set; }

        public virtual ICollection<DenominationEntity> Denominations { get; set; }

        public virtual ICollection<DepositAggregationEntity> DepositAggregations { get; set; }

        public virtual ICollection<VoucherReconcileEntity> VoucherReconciles { get; set; }
    }
}