using System;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    public class InstallationLogEntity
    {
        public int Id { get; set; }

        public int AutoSequence { get; set; }

        public int OrderNo { get; set; }

        public int RequestId { get; set; }

        public int EmployeeNo { get; set; }

        public DateTime? CreateDate { get; set; }

        public TimeSpan Time { get; set; }

        [StringLength(500)]
        public string CommentsLine1 { get; set; }

        public long CustomerNo { get; set; }

        [StringLength(1)]
        public string Type { get; set; }
    }
}