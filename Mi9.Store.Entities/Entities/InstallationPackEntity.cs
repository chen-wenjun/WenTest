using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installation pack entity (InstServHdr table).
    /// </summary>
    public class InstallationPackEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the store number.
        /// </summary>
        public short StoreNumber { get; set; }

        /// <summary>
        /// Gets or sets the department id.
        /// </summary>
        public short DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the class id.
        /// </summary>
        public short ClassId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether or not an Installation Pack 
        /// requires a prior Technical Visit: ‘Y’ = Yes, ‘I’ = No.
        /// </summary>
        [StringLength(1)]
        public string TypeServ { get; set; }

        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        public virtual DepartmentEntity Department { get; set; }

        /// <summary>
        /// Gets or sets the department class.
        /// </summary>
        public virtual DepartmentClassEntity DepartmentClass { get; set; }

        /// <summary>
        /// Gets or sets the installation services.
        /// </summary>
        public virtual ICollection<InstallationPackDetailEntity> Details { get; set; }

        /// <summary>
        /// Gets or sets the requests.
        /// </summary>
        public virtual ICollection<InstallationRequestEntity> Requests { get; set; }

        public string GetEntityType()
        {
            if (Details == null || !Details.Any())
            {
                //throw new InvalidOperationException("Installation pack contains no details (no services).");
                return null;
            }

            var serviceType = Details.First().TypeServ;
            if (serviceType.Equals("v", StringComparison.OrdinalIgnoreCase))
            {
                return serviceType;
            }

            if (serviceType.Equals("i", StringComparison.OrdinalIgnoreCase))
            {
                return serviceType;
            }

            throw new InvalidOperationException("The type of installation pack is not supported.");
        }
    }
}
