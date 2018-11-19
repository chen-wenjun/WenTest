namespace MI9.HDM.Store.BackOffice.Data.Entities.Handheld
{
    using MI9.HDM.Store.BackOffice.Core.Handheld;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CONFIG_HandheldLogs")]
    public class LogEntryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public LogPriorityEnum Priority { get; set; }

        public string Source { get; set; }

        public string Text { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
