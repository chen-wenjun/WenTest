namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The type of sale entity.
    /// </summary>
    public class TypeOfSaleEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public byte Id { get; set; }

        /// <summary>
        /// Gets or sets the days until delete.
        /// </summary>
        public byte DaysUntilDelete { get; set; }

        public byte OrderTypeCd { get; set; }
    }
}