namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public abstract class LookupRequest 
    {
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
    }
}