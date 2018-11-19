using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PaymentMethodEntity
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<VendorEntity> Vendors { get; set; } 
    }
}
