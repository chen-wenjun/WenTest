using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DepartmentSubClassEntity
    {
        public short DepartmentId { get; set; }

        public short ClassId { get; set; }

        public short SubClassId { get; set; }

        public string Description { get; set; }

        public virtual DepartmentEntity Department { get; set; }

        public virtual DepartmentClassEntity DeparmentClass { get; set; }

        public virtual ICollection<ItemSkuEntity> ItemSkus { get; set; }
    }
}
