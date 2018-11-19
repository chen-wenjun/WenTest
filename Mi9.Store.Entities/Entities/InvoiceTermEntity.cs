
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class InvoiceTermEntity
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<VendorEntity> Vendors { get; set; }

        public virtual ICollection<PurchaseOrderEntity> PurchaseOrders { get; set; }
    }
}
