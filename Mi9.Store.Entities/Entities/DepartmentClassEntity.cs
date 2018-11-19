using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DepartmentClassEntity
    {
        public short DepartmentId { get; set; }

        public short ClassId { get; set; }

        public string Description { get; set; }

        public virtual DepartmentEntity Department { get; set; }

        public virtual ICollection<DepartmentSubClassEntity> DepartmentSubClasses { get; set; }

        public virtual ICollection<ItemSkuEntity> ItemSkus { get; set; }

        public virtual ICollection<InstallerEntity> EligibleInstallers { get; set; }

        public virtual ICollection<InstallationPackEntity> InstallationPacks { get; set; }
    }
}
