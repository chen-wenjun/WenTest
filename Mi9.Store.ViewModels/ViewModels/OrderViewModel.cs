using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.Converters;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class OrderViewModel : IValidatableObject
    {
        private bool _isReadOnly;

        private DateTime _created;

        private OrderTypeBaseViewModel _orderType;

        private string _orderTypeName;

        private string _orderTypeKey;

        public OrderViewModel()
        {
            if (this is IAdvanceCancellationOrder)
            {
                NeedShowCancellationDialog = true;
            }

            Status = CustomerOrderStatusString.New;
            Created = DateTime.Now;
            PONumber = string.Empty;
            Comments = string.Empty;
            OrderType = new Estimate();
            TranDate = DateTime.Now;
        }

        public byte TypeOfSale { get; set; }

        public IOrderDefinitionViewReader OrderDefinitonViewReader { get; set; }

        public decimal TaxAmount
        {
            get
            {
                return Items == null ? 0 : Items.Sum(t => t.ExtendedTaxAmount);
            }
        }

        public decimal TxbleNonMdse
        {
            get
            {
                return Items == null ? 0 : Items.Where(t => t.HasTaxes && t.ItemSku.ItemType != "SKU").Sum(t => t.ExtendedAmount);
            }
        }

        public decimal TaxableSales
        {
            get
            {
                return Items == null ? 0 : Items.Where(t => t.HasTaxes).Sum(t => t.ExtendedAmount);
            }
        }

        public decimal NonTaxNonMde
        {
            get
            {
                return Items == null ? 0 : Items.Where(t => !t.HasTaxes && t.ItemSku.ItemType != "SKU").Sum(t => t.ExtendedAmount);
            }
        }

        public decimal NonTaxSales
        {
            get
            {
                return Items == null ? 0 : Items.Where(t => !t.HasTaxes).Sum(t => t.ExtendedAmount);
            }
        }

        public string EmployeeNumber { get; set; }

        public string EmployeeName { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItemViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "orderNumber")]
        public int OrderNumber { get; set; }

        [JsonProperty(PropertyName = "created")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Created
        {
            get
            {
                DateTime date = _created == DateTime.MinValue ? DateTime.Now : _created;

                return date;
            }

            set
            {
                _created = value;
            }
        }

        [JsonProperty(PropertyName = "expired")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime ExpireDate { get; set; }

        [JsonProperty(PropertyName = "changed")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime ChangedDate
        {
            get { return Created; }
        }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public RequiredCustomerViewModel Customer { get; set; }

        [JsonProperty(PropertyName = "deliveryCustomer")]
        public DeliveryCustomerViewModel DeliveryCustomer { get; set; }

        [JsonProperty(PropertyName = "salesAssociate")]
        public StoreEmployeeViewModel SalesAssociate { get; set; }

        [JsonProperty(PropertyName = "storeRemarks")]
        public string Comments { get; set; }

        [JsonProperty(PropertyName = "tender")]
        public string Tender { get; set; }

        [JsonProperty(PropertyName = "customerBuyer")]
        public string AuthorizedBuyer { get; set; }

        [JsonProperty(PropertyName = "customerEmployee")]
        public string CustomerEmployee { get; set; }

        [JsonProperty(PropertyName = "poNumber")]
        public string PONumber { get; set; }

        [JsonProperty(PropertyName = "orderType")]
        public string OrderTypeName
        {
            get
            {
                return OrderType != null ? OrderType.StoreOrderTypeName : _orderTypeName;
            }

            set
            {
                _orderTypeName = value;
            }
        }

        [JsonProperty(PropertyName = "orderTypeKey")]
        public string OrderTypeKey
        {
            get
            {
                return OrderType != null ? OrderType.StoreOrderType : _orderTypeKey;
            }

            set
            {
                _orderTypeKey = value;
            }
        }

        public OrderTypeBaseViewModel OrderType
        {
            get
            {
                if (OrderDefinitonViewReader != null)
                {
                    _orderType = OrderDefinitonViewReader.ReadByOrderType(_orderType.StoreOrderType);
                }

                return _orderType;
            }

            set
            {
                _orderType = value;
            }
        }

        [JsonProperty(PropertyName = "orderKind")]
        public string OrderKind { get; set; }

        [JsonProperty(PropertyName = "orderStatus")]
        public virtual string OrderStatus { get; set; }

        [JsonProperty(PropertyName = "selectedProject")]
        public string SelectedProject { get; set; }

        [JsonProperty(PropertyName = "cancellationStatus")]
        public string LayawayCancellationStatus { get; set; }

        public decimal LayawayCancellationPenalty { get; set; }

        [JsonProperty(PropertyName = "preCheckoutCardNumber")]
        public string PreCheckoutCardNumber { get; set; }

        [JsonProperty(PropertyName = "wasValidatedAtPOS")]
        public bool WasValidatedAtPOS { get; set; }

        public DateTime? LastValidationDate { get; set; }

        [JsonProperty(PropertyName = "sccId")]
        public int? SccId { get; set; }

        [JsonProperty(PropertyName = "scc")]
        public PricingAgreementViewModel PricingAgreement { get; set; }

        [JsonProperty(PropertyName = "specialPriceRequest")]
        public SpecialPriceRequestViewModel SpecialPriceRequest { get; set; }

        [JsonProperty(PropertyName = "specialPriceRequests")]
        public List<SpecialPriceRequestViewModel> SpecialPriceRequests { get; set; }

        [JsonProperty(PropertyName = "errorService")]
        public string ErrorService { get; set; }

        [JsonProperty(PropertyName = "depositPercent")]
        public decimal DepositPercent
        {
            get
            {
                var total = TotalDeposits;
                if (OrderType != null && (OrderType is ISpecialOrderType || OrderType.StoreOrderType == "Special_Order_Deposit" || OrderType.StoreOrderType == "AR_Special_Order_Deposit"))
                {
                    total = SpecialDeposits;
                }

                if (total == 0)
                {
                    return 0;
                }

                var percents = Math.Round(DepositAmount * 100 / total, 2);

                return percents;
            }
        }

        [JsonProperty(PropertyName = "depositAmount")]
        public decimal DepositAmount { get; set; }

        [JsonProperty(PropertyName = "SoldFirstName")]
        public string SoldFirstName { get; set; }

        [JsonProperty(PropertyName = "SoldBusName")]
        public string SoldBusName { get; set; }

        [JsonProperty(PropertyName = "ShipBusName")]
        public string ShipBusName { get; set; }

        public decimal TotalDeposits
        {
            get
            {
                return TaxAmount + TaxableSales + NonTaxSales;
            }
        }

        public decimal SpecialDeposits
        {
            get
            {
                if (Items == null)
                {
                    return 0;
                }

                return Items.Where(t => t.ItemSku != null
                        && t.ItemSku.ItemType == "SKU"
                        && t.ItemSku.SpecialItemType != "normal")
                        .Sum(t => t.ExtendedAmount);
            }
        }

        [JsonProperty(PropertyName = "validateDepositPercent")]
        public decimal ValidateDepositPercent { get; set; }

        [JsonProperty(PropertyName = "validateDepositAmount")]
        public decimal ValidateDepositAmount { get; set; }

        [JsonProperty(PropertyName = "isReadOnlyForOrderItems")]
        public bool IsReadOnlyForOrderItems
        {
            get
            {
                if (OrderStatus == "Cancelled" || OrderStatus == "Completed")
                {
                    return true;
                }

                return CheckReadOnlyState() || _isReadOnly;
            }

            set
            {
                _isReadOnly = value;
            }
        }

        public bool IsReadOnly { get; set; }

        [JsonProperty(PropertyName = "isSaveDisabled")]
        public bool IsSaveDisabled
        {
            get
            {
                if (CheckIsSaveDisable())
                {
                    return true;
                }

                if (OrderStatus == "Completed")
                {
                    return true;
                }

                return IsReadOnly;
            }

            set
            {
                IsReadOnly = value;
            }
        }

        [JsonProperty(PropertyName = "needShowCancellationDialog")]
        public bool NeedShowCancellationDialog { get; private set; }

        [JsonProperty(PropertyName = "CopySource")]
        public string CopySource { get; set; }

        public DateTime? TranDate { get; set; }

        public List<OrderTypeBaseViewModel> AvailableTypes
        {
            get
            {
                var availableTypes = GetAvailableTypes().ToList();
                if (Items == null || !Items.Any())
                {
                    availableTypes.ForEach(t => t.WarningMessages.Add(Strings.NeedAtLeastOneOrderItem));
                }

                if (Items != null
                    && Items.Sum(t => t.ExtendedAmount) == 0)
                {
                    availableTypes.ForEach(t => t.WarningMessages.Add(Strings.NeedNotZeroOrderTotal));
                }

                if (Items != null 
                    && Items.Any(t => t.ItemSku.SpecialItemType != "normal" && t.ItemSku.Description.Substring(0, 5) != "(FMS)")
                    && Items.Where(t => t.ItemSku.SpecialItemType != "normal" && t.ItemSku.Description.Substring(0, 5) != "(FMS)").Sum(t => t.ExtendedAmount) == 0)
                {
                    availableTypes.ForEach(t => t.WarningMessages.Add(Strings.NeedNotZeroDeposit));
                }

                return availableTypes;
            }
        }

        protected virtual List<OrderTypeBaseViewModel> GetAvailableTypes()
        {
            return new List<OrderTypeBaseViewModel>();
        }

        protected virtual bool CheckReadOnlyState()
        {
            return CheckSPVIsPending();
        }

        protected bool CheckSPVIsPending()
        {
            return SpecialPriceRequest != null && SpecialPriceRequest.Status == "Pending";
        }

        protected virtual bool CheckIsSaveDisable()
        {
            return false;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Items == null || !Items.Any())
            {
                yield return new ValidationResult(Strings.NeedAtLeastOneOrderItem);
            }
        }
    }
}