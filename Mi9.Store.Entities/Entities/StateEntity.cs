using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class StateEntity
    {
        public string Id { get; set; }

        public string StateName { get; set; }

        public short CountryId { get; set; }

        public virtual CountryEntity Country { get; set; }

        public virtual ICollection<CustomerEntity> CustomersJob { get; set; }

        public virtual ICollection<CustomerEntity> Customers { get; set; }

        public virtual ICollection<OrderEntity> ShipOrders { get; set; }

        public virtual ICollection<OrderEntity> SoldOrders { get; set; }

        public virtual ICollection<StoreEntity> Stores { get; set; }

        public virtual ICollection<SccAddressEntity> Adresses { get; set; }
      
    }
}