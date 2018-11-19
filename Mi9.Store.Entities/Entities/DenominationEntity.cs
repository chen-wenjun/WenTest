using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DenominationEntity
    {
        public int DenominationId { get; set; }

        public string Description { get; set; }

        public int DisplayOrder { get; set; }

        public decimal Price { get; set; }

        public bool IsCustom { get; set; }

        public bool IsDynamic { get; set; }

        public byte TenderCode { get; set; }

        public virtual TenderTypeEntity TenderType { get; set; }

        public int? TenderId { get; set; }

        public bool IsActive { get; set; }

        public virtual TenderEntity Tender { get; set; }

        public virtual ICollection<WithdrawalDenominationEntity> WithdrawalDenominations { get; set; }

        public virtual ICollection<VoucherReconcileDetailsEntity> VoucherReconcileDetails { get; set; }
    }
}