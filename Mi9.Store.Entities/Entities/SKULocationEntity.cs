using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    public class SKULocationEntity
    {
        public int Id { get; set; }
        public int BayId { get; set; }
        public string Level { get; set; }
        public long SKU { get; set; }
        public string CreatedFrom { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? AmendedBy { get; set; }
        public DateTime? DateAmended { get; set; }
        public int Amount { get; set; }
        public bool Auditable { get; set; }
        public int IsSuitable { get; set; }

        [ForeignKey("BayId")]
        public  BayEntity  Bay { get; set; }
        [ForeignKey("SKU")]
        public ItemSkuEntity ItemSku { get; set; }

        public string Top { get; set; }
        public int CountQty { get; set; }
    }
}
