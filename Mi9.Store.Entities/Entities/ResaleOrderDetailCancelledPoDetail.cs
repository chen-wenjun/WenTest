using System;

namespace Mi9.Store.Entities.Entities
{
    public class ResaleOrderDetailCancelledPoDetail
    {
        public int OrderNumber { get; set;}
        public string PONumber { get; set; }
        public long Sku { get;set;}
        
        public decimal Quantity { get;set;}
        public DateTime LinkedDate { get; set;}
        public int LinkedEmp { get;set;}
        public DateTime? SaleDate { get; set; }
    }
}
