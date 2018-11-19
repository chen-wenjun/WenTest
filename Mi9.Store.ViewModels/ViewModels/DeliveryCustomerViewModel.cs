namespace Mi9.Store.ViewModels.ViewModels
{
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization.OptIn)]
    public class DeliveryCustomerViewModel : CustomerViewModel
    {
        [JsonProperty(PropertyName = "receiverName")]
        public string ReceiverName { get; set; }
        
        [JsonProperty(PropertyName = "fullName")]
        public override string FullName
        {
            get
            {
                var fullName = string.IsNullOrEmpty(base.FullName) ? ReceiverName : base.FullName;
                return fullName;
            }

            //set
            //{
            //    base.FullName = value;
            //}
        }
    }
}