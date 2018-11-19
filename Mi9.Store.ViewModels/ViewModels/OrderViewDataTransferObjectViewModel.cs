using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class OrderViewDataTransferObject
    {
        public List<OrderItemViewModel> Items { get; set; }

        public int OrderNumber { get; set; }

        public DateTime Created { get; set; }

        public DateTime ExpireDate { get; set; }

        public DateTime ChangedDate { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }

        public RequiredCustomerViewModel Customer { get; set; }

        public DeliveryCustomerViewModel DeliveryCustomer { get; set; }

        public StoreEmployeeViewModel SalesAssociate { get; set; }

        public string EmployeeNumber { get; set; }

        public string EmployeeName { get; set; }

        public string SoldFirstName { get; set; }

        public string SoldBusName { get; set; }

        public string ShipBusName { get; set; }

        public string Comments { get; set; }

        public string Tender { get; set; }

        public string AuthorizedBuyer { get; set; }

        public string CustomerEmployee { get; set; }

        public string PONumber { get; set; }

        public string OrderTypeName { get; set; }

        public OrderTypeBaseViewModel OrderType { get; set; }

        public string OrderKind { get; set; }

        public string OrderStatus { get; set; }

        public string SelectedProject { get; set; }

        public string LayawayCancellationStatus { get; set; }

        public decimal LayawayCancellationPenalty { get; set; }

        public string PreCheckoutCardNumber { get; set; }

        public bool WasValidatedAtPOS { get; set; }

        public DateTime? LastValidationDate { get; set; }

        public int? SccId { get; set; }
        
        public PricingAgreementViewModel PricingAgreement { get; set; }

        public SpecialPriceRequestViewModel SpecialPriceRequest { get; set; }

        public List<SpecialPriceRequestViewModel> SpecialPriceRequests { get; set; }

        public decimal DepositPercent { get; set; }

        public decimal DepositAmount { get; set; }

        public decimal ValidateDepositPercent { get; set; }

        public decimal ValidateDepositAmount { get; set; }

        public bool IsReadOnly { get; set; }

        public decimal TotalOrderCalculated { get; set; }

        public int? DefinitionId { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TxbleNonMdse { get; set; }

        public decimal NonTaxNonMde { get; set; }

        public decimal TaxableSales { get; set; }

        public decimal NonTaxSales { get; set; }

        public DateTime? TranDate { get; set; }

        public string ErrorService{ get; set; }

        public string CopySource { get; set; }
    }
}