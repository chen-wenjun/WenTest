// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvCategory.cs" company="MI9Retail">
//   Copyright (c) 2015 MI9Retail. All rights reserved.
// </copyright>
// <summary>
//   defines inventory categories
// </summary>
// <remarks>
// 0garcia06032015 initial implementation
// <remarks>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// inventory categories
    /// 
    /// </summary>
    [Table("InvCategory")]
    public class InventoryCategoryEntity
    {       
       /// <summary>
       /// key: category id
       /// </summary>
        public int Id {get; set;}
               
	    /// <summary>
	    /// short name or code
	    /// </summary>
        public string Code {get; set;}

        /// <summary>
        /// long description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 0 for active - 1 = disabled
        /// </summary>
        public bool? Disabled { get; set; }
    }
}