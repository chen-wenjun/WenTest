namespace Mi9.Store.Entities.Entities
{
    public class AuthrizdSignr
    {
        public long CustomerID { get; set; }
        public short SubKey { get; set; }
        public short Sequence { get; set; }
        public string AuthSigner { get; set; }
    }
}
