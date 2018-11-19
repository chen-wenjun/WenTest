using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DepartmentEntity
    {
        public short DepartmentId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<DepartmentClassEntity> DepartmentClasses { get; set; }

        public virtual ICollection<DepartmentSubClassEntity> DepartmentSubClasses { get; set; }

        public virtual ICollection<VendorEntity> Vendors { get; set; }

        public virtual ICollection<ItemKeyWordEntity> KeyWords { get; set; }

        public virtual ICollection<ItemSkuEntity> ItemSkus { get; set; }

        public virtual ICollection<InstallationPackEntity> InstallationPacks { get; set; }

        public ICollection<PurchaseOrderEntity> PurchaseOrders { get; set; }
    }
}