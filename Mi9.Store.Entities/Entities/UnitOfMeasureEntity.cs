namespace Mi9.Store.Entities.Entities
{
    using System.Collections.Generic;
    
    public class UnitOfMeasureEntity
    {
        public string Uom { get; set; }

        public string Description { get; set; }

        public bool FractQty { get; set; }

        public ICollection<ItemSkuEntity> SkuItems { get; set; }

        public virtual ICollection<InstallationPackDetailEntity> InstallationPackDetails { get; set; }
    }
}