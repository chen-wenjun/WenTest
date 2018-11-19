using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The season entity.
    /// </summary>
    public class SeasonEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public byte Id { get; set; }

        /// <summary>
        /// Gets or sets the start season 1.
        /// </summary>
        public short? StartSeason1 { get; set; }

        /// <summary>
        /// Gets or sets the start season 2.
        /// </summary>
        public short? StartSeason2 { get; set; }

        /// <summary>
        /// Gets or sets the start season 3.
        /// </summary>
        public short? StartSeason3 { get; set; }

        /// <summary>
        /// Gets or sets the end season 1.
        /// </summary>
        public short? EndSeason1 { get; set; }

        /// <summary>
        /// Gets or sets the end season 2.
        /// </summary>
        public short? EndSeason2 { get; set; }

        /// <summary>
        /// Gets or sets the end season 3.
        /// </summary>
        public short? EndSeason3 { get; set; }

        /// <summary>
        /// Gets or sets the item replens.
        /// </summary>
        public virtual ICollection<ItemReplenEntity> ItemReplens { get; set; }
    }
}
