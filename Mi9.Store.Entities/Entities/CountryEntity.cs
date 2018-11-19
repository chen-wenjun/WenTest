using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CountryEntity
    {
        public short Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public virtual CountryDefinitionEntity Definition { get; set; }

        public virtual ICollection<StateEntity> States { get; set; }
    }
}