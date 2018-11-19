namespace MI9.HDM.Store.BackOffice.Data.Entities.Handheld
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CONFIG_HandheldExceptions")]
    public class ExceptionEntryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public int HResult { get; set; }

        public string Message { get; set; }

        public string Source { get; set; }

        public string InnerMessage { get; set; }

        public string InnerSource { get; set; }

        public string StackTrace { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
