using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The transport company entity model.
    /// </summary>
    public class TransportCompanyEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Key { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<DepositAggregationEntity> DepositAggregations { get; set; }
    }
}