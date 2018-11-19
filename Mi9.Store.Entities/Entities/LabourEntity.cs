using System;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The labour entity.
    /// </summary>
    public class LabourEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the week id.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the employee no.
        /// </summary>
        public int EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        public virtual EmployeeEntity Employee { get; set; }
    }
}