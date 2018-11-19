// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuditEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The audit entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The audit entity.
    /// </summary>
    public class AuditEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the employee no.
        /// </summary>
        public int? EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the operation type.
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or sets the table name.
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the column name.
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the primary key column name.
        /// </summary>
        public string PrimaryKeyColumnName { get; set; }

        /// <summary>
        /// Gets or sets the primary key value.
        /// </summary>
        public string PrimaryKeyValue { get; set; }

        /// <summary>
        /// Gets or sets the old value.
        /// </summary>
        public string OldValue { get; set; }

        /// <summary>
        /// Gets or sets the new value.
        /// </summary>
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or sets the transaqtion id.
        /// </summary>
        public Guid TransaqtionId { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        public virtual EmployeeEntity Employee { get; set; }
    }
}
