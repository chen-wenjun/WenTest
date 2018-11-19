using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Mi9.Store.ViewModels.Converters;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PricingAgreementByStateViewModel
    {
        public PricingAgreementViewModel Agreement { get; set; }
        public string Status { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class PricingAgreementViewModel : IValidatableObject
    {
        private long customerId;

        private string _status;

        public PricingAgreementViewModel()
        {
            Status = SccStatus.New;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "payrollid")]
        public string PayrollId { get; set; }

        [JsonProperty(PropertyName = "errorEmail")]
        public bool ErrorEmail { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status
        {
            get
            {
                if (ConsumptionEndDate.HasValue && ConsumptionEndDate.Value.Date.AddDays(1).AddSeconds(-1) <= DateTime.UtcNow.Date)
                {
                    return SccStatus.Expired;
                }
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        [JsonProperty(PropertyName = "statusTitle")]
        public string StatusTitle
        {
            get { return SccStatus.Dict.ContainsKey(Status) ? SccStatus.Dict[Status] : SccStatus.Dict[SccStatus.Unknown]; }
        }

        [JsonProperty(PropertyName = "statusComments")]
        public string StatusComments { get; set; }

        [JsonProperty(PropertyName = "typeOfWork")]
        public string TypeOfWork { get; set; }

        [JsonProperty(PropertyName = "statusOfWork")]
        public string StatusOfWork { get; set; }

        [JsonProperty(PropertyName = "estimatedStartDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime EstimatedStartDate { get; set; }

        [JsonProperty(PropertyName = "estimatedEndDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime EstimatedEndDate { get; set; }

        [JsonProperty(PropertyName = "probablySuccess")]
        public decimal ProbablySuccess { get; set; }

        [JsonProperty(PropertyName = "paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty(PropertyName = "creditStatus")]
        public string CreditStatus { get; set; }

        [JsonProperty(PropertyName = "availableCredit")]
        public decimal AvailableCredit { get; set; }

        [JsonProperty(PropertyName = "consumptionPeriod")]
        public int ConsumptionPeriod { get; set; }

        [JsonProperty(PropertyName = "consumptionStartDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? ConsumptionStartDate { get; set; }

        [JsonProperty(PropertyName = "consumptionEndDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? ConsumptionEndDate
        {
            get
            {
                if (ConsumptionStartDate.HasValue)
                {
                    return ConsumptionStartDate.Value.AddDays(ConsumptionPeriod);
                }
                return null;
            }
        }

        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "deliverName")]
        public string DeliverName { get; set; }

        [JsonProperty(PropertyName = "deliveryMethod")]
        public string DeliveryMethod { get; set; }

        [JsonProperty(PropertyName = "receiverName")]
        public string ReceiverName { get; set; }

        [JsonProperty(PropertyName = "receiverPhone")]
        public string ReceiverPhone { get; set; }

        [JsonProperty(PropertyName = "quatationDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime QuatationDate { get; set; }

        [JsonProperty(PropertyName = "sccDueDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? SccDueDate { get; set; }

        [JsonProperty(PropertyName = "paperworkTargetDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? PaperworkTargetDate { get; set; }

        [JsonProperty(PropertyName = "created")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "updated")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Updated { get; set; }

        [JsonProperty(PropertyName = "address")]
        public SccAddressViewModel Address { get; set; }

        [JsonProperty(PropertyName = "requirement")]
        public SccRequirementViewModel Requirement { get; set; }

        [JsonProperty(PropertyName = "receivingHours")]
        public ReceivingHoursViewModel ReceivingHours { get; set; }

        [JsonProperty(PropertyName = "customerId")]
        public long CustomerId
        {
            get
            {
                return Customer != null && Customer.CustomerId.HasValue && Customer.CustomerId.Value > 0
                           ? Customer.CustomerId.Value
                           : customerId;
            }

            set
            {
                customerId = value;
            }
        }

        [JsonProperty(PropertyName = "subKey")]
        public short SubKey { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public CustomerViewModel Customer { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<SccItemViewModel> SccItems { get; set; }

        [JsonProperty(PropertyName = "employeeNo")]
        public int? EmployeeNo { get; set; }

        [JsonProperty(PropertyName = "buyer")]
        public string AuthBuyer { get; set; }

        [JsonProperty(PropertyName = "poNumber")]
        public string PONumber { get; set; }

        [JsonProperty(PropertyName = "employee")]
        public StoreEmployeeViewModel Employee { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CustomerId < 0)
            {
                yield return new ValidationResult("CustomerId is required field");
            }
        }
    }
}