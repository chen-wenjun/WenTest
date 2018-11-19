using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DestinationEntity
    {
        public short? DestinationCode { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public DateTime? LastMntDate { get; set; }

        public string Comment { get; set; }

        public ICollection<PurchaseOrderEntity> PurchaseOrders { get; set; }
    }
}
