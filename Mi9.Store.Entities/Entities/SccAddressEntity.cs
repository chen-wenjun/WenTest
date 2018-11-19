namespace Mi9.Store.Entities.Entities
{
    public class SccAddressEntity
    {
        public long Id { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string StateId { get; set; }

        public string Telephone1 { get; set; }

        public string Telephone2 { get; set; }

        public string Fax { get; set; }

        public virtual PricingAgreementEntity Agreement { get; set; }

        public virtual StateEntity State{ get; set; } 
    }
}