using System;

namespace Mi9.Store.Entities.Entities
{
    public class CouponEntity
    {
        public int CouponId { get; set; }
        public byte CouponType { get; set; }
        public long GetSku { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short GetQty { get; set; }
        public decimal GetAmount { get; set; }
    }
}
