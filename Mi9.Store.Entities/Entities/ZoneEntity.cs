using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class ZoneEntity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public ICollection<BayEntity> Bays { get; set; }
    }
}
