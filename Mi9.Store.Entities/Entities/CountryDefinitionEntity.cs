namespace Mi9.Store.Entities.Entities
{
    public class CountryDefinitionEntity
    {
        public short Id { get; set; }

        public string FirstAddressLine { get; set; }

        public string SecondAddresLine { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string CountryName { get; set; }

        public virtual CountryEntity Country { get; set; }
    }
}
