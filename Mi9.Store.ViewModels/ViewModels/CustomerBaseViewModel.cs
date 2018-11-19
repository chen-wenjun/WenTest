using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    [JsonObject(MemberSerialization.OptIn)]
    public class CustomerBaseViewModel
    {
        private const int NameLength = 35;

        private static readonly long GenericCustomerId = GenericCustomerContainerViewMOdel.GenericCustomerId;

        public long GenericId
        {
            get
            {
                return GenericCustomerId;
            }
        }

        [JsonProperty(PropertyName = "isGeneric")]
        public bool IsGeneric
        {
            get
            {
//                return GenericCustomerId == this.CustomerId || this.CustomerId == 0 || this.CustomerId == null;
                return CustomerId == null || GenericCustomerId == CustomerId || CustomerId == 11110000004;
            }
        }

        //private string firstName;

        [JsonProperty(PropertyName = "customerId")]
        public long? CustomerId { get; set; }

        [JsonProperty(PropertyName = "subKey")]
        public short? SubKey { get; set; }

        [JsonProperty(PropertyName = "rfc")]
        public string Rfc { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        //{
        //    get
        //    {
        //        if (IsGeneric)
        //        {
        //            return string.IsNullOrWhiteSpace(firstName) ? firstName : firstName.Trim();
        //        }

        //        return firstName;
        //    }

        //    set
        //    {
        //        firstName = value;
        //    }
        //}

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "middleInitial")]
        public string MiddleInitial { get; set; }

        [JsonProperty(PropertyName = "businessName")]
        public string BusinessName { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public virtual string FullName
        {
            get
            {
                var fullName = !string.IsNullOrEmpty(LastName) ? FirstName + " " + LastName : FirstName;
                fullName = string.IsNullOrEmpty(fullName) ? BusinessName : fullName;

                return fullName;
            }

            //set
            //{
            //    if (IsGeneric)
            //    {
            //        if (value != null && value.Length > NameLength)
            //        {
            //            FirstName = value.Substring(0, NameLength);
            //            LastName = value.Substring(NameLength + 1, value.Length - NameLength - 1);
            //        }
            //        else
            //        {
            //            FirstName = value;
            //        }
            //    }
            //}
        }
    }
}