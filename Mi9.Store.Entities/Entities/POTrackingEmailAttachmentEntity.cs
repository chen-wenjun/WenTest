namespace Mi9.Store.Entities.Entities
{
    public class PoTrackingEmailAttachmentEntity
    {
        public long Id { get; set; }
        public string PONumber { get; set; }
        public string FileName { get; set; }
        
        public virtual PoTrackingEntryEntity PoTrackingEntry { get; set; }
        
    }
}
