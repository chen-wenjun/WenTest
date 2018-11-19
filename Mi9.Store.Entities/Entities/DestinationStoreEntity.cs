using System;

namespace Mi9.Store.Entities.Entities
{
    public class DestinationStoreEntity
    {
        public short RequestStoreId { get; set; }

        public bool? RequestStoreType { get; set; }

        public short SourceStoreId { get; set; }

        public bool? SourceStoreType { get; set; }

        public bool PermAuth { get; set; }

        public DateTime? AuthStartDate { get; set; }

        public DateTime? AuthExpiredDate { get; set; }

        public bool Nearby { get; set; }

        public bool InDistrict { get; set; }

        public virtual StoreEntity RequestStore { get; set; }

        public virtual StoreEntity SourceStore { get; set; }
    }
}