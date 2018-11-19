using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The order entity.
    /// </summary>
    public class OrderEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderEntity"/> class.
        /// </summary>
        public OrderEntity()
        {
            // These initial values are needed because there are table constraints for these fields.
            OrderItems = new Collection<OrderItemEntity>();

            RecStatus = string.Empty;
            TypeOfSale = 0;
            EmployeeNo = 0;
            TaxExemptNo = string.Empty;
            PONumber = string.Empty;
            TaxAmount = 0;
            TaxableSales = 0;
            NonTaxSales = 0;
            NonTaxSales = 0;
            Deposits = 0;
            SoldBusName = string.Empty;
            SoldToAdd1 = string.Empty;
            SoldToAdd2 = string.Empty;
            SoldToCity = string.Empty;
            SoldToZip = string.Empty;
            ShipBusName = string.Empty;
            ShipToAdd1 = string.Empty;
            ShipToAdd2 = string.Empty;
            ShipToCity = string.Empty;
            ShipToZip = string.Empty;
            PhoneNumber = string.Empty;
            AltPhoneNumb = string.Empty;
            SoldLastName = string.Empty;
            SoldFirstName = string.Empty;
            SoldToStateId = null;
            ShipLastName = string.Empty;
            ShipFirstName = string.Empty;
            ShipMidInit = string.Empty;
            ShipToStateId = null;
            DeliverType = string.Empty;
            Condition = string.Empty;
            SoldToAdd3 = string.Empty;
            ShipToAdd3 = string.Empty;

            Opportunity = string.Empty;
            Comments = string.Empty;
            CheckNumber = string.Empty;
            BetweenStreets = string.Empty;
            Latitude = string.Empty;
            Length = string.Empty;
            AuthBuyer = string.Empty;
            CustJobNo = string.Empty;
            OrderStatus = "A";
            OrderType = string.Empty;
            TOS = string.Empty;
            OrigTender = string.Empty;
            CurrDeposit = 0;
            OutsideSlpn = 0;
            Condition = "D";
            DeliverType = "F";
            OrderStatus = "F";
            OrderType = "Z";
            OrigTender = "X";
            DefinitionId = 1;
            TaxCode = "1";
        }

        #region ActualField

        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the employee no.
        /// </summary>
        public int EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets the account no.
        /// </summary>
        public long AccountNo { get; set; }

        /// <summary>
        /// Gets or sets the sub account.
        /// </summary>
        public short SubAccount { get; set; }

        /// <summary>
        /// Gets or sets the account no.
        /// </summary>
        public long? DeliveryAccountNo { get; set; }

        /// <summary>
        /// Gets or sets the sub account.
        /// </summary>
        public short? DeliverySubAccount { get; set; }

        /// <summary>
        /// Gets or sets the sold last name.
        /// </summary>
        [StringLength(35)]
        public string SoldLastName { get; set; }

        /// <summary>
        /// Gets or sets the sold first name.
        /// </summary>
        [StringLength(35)]
        public string SoldFirstName { get; set; }

        /// <summary>
        /// Gets or sets the sold to state.
        /// </summary>
        [StringLength(3)]
        public string SoldToStateId { get; set; }

        /// <summary>
        /// Gets or sets the sold bus name.
        /// </summary>
        [StringLength(35)]
        public string SoldBusName { get; set; }

        /// <summary>
        /// Gets or sets the sold to add 1.
        /// </summary>
        [StringLength(35)]
        public string SoldToAdd1 { get; set; }

        /// <summary>
        /// Gets or sets the sold to add 2.
        /// </summary>
        [StringLength(35)]
        public string SoldToAdd2 { get; set; }

        /// <summary>
        /// Gets or sets the sold to city.
        /// </summary>
        [StringLength(25)]
        public string SoldToCity { get; set; }

        /// <summary>
        /// Gets or sets the sold to zip.
        /// </summary>
        [StringLength(9)]
        public string SoldToZip { get; set; }

        /// <summary>
        /// Gets or sets the sold to add 3.
        /// </summary>
        [StringLength(25)]
        public string SoldToAdd3 { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [StringLength(30)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        [StringLength(30)]
        public string Length { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [StringLength(16)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the alt phone numb.
        /// </summary>
        [StringLength(16)]
        public string AltPhoneNumb { get; set; }

        /// <summary>
        /// Gets or sets the check number.
        /// </summary>
        [StringLength(20)]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the ship bus name.
        /// </summary>
        [StringLength(35)]
        public string ShipBusName { get; set; }

        /// <summary>
        /// Gets or sets the ship to add 1.
        /// </summary>
        [StringLength(35)]
        public string ShipToAdd1 { get; set; }

        /// <summary>
        /// Gets or sets the ship to add 2.
        /// </summary>
        [StringLength(35)]
        public string ShipToAdd2 { get; set; }

        /// <summary>
        /// Gets or sets the ship to city.
        /// </summary>
        [StringLength(25)]
        public string ShipToCity { get; set; }

        /// <summary>
        /// Gets or sets the ship to zip.
        /// </summary>
        [StringLength(9)]
        public string ShipToZip { get; set; }

        /// <summary>
        /// Gets or sets the ship last name.
        /// </summary>
        [StringLength(35)]
        public string ShipLastName { get; set; }

        /// <summary>
        /// Gets or sets the ship first name.
        /// </summary>
        [StringLength(35)]
        public string ShipFirstName { get; set; }

        /// <summary>
        /// Gets or sets the ship.
        /// </summary>
        [StringLength(1)]
        public string ShipMidInit { get; set; }

        /// <summary>
        /// Gets or sets the ship to state.
        /// </summary>
        [StringLength(3)]
        public string ShipToStateId { get; set; }

        /// <summary>
        /// Gets or sets the ship to add 3.
        /// </summary>
        [StringLength(25)]
        public string ShipToAdd3 { get; set; }

        /// <summary>
        /// Gets or sets the tax amount.
        /// </summary>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the taxable sales.
        /// </summary>
        public decimal TaxableSales { get; set; }

        /// <summary>
        /// Gets or sets the non tax sales.
        /// </summary>
        public decimal NonTaxSales { get; set; }

        /// <summary>
        /// Gets or sets the txble non mdse.
        /// </summary>
        public decimal TxbleNonMdse { get; set; }

        /// <summary>
        /// Gets or sets the non tax non mde.
        /// </summary>
        public decimal NonTaxNonMde { get; set; }

        /// <summary>
        /// Gets or sets the tax exempt no.
        /// </summary>
        [StringLength(20)]
        public string TaxExemptNo { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the expire date.
        /// </summary>
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// Gets or sets the deposits.
        /// </summary>
        public decimal Deposits { get; set; }

        /// <summary>
        /// Gets or sets the current deposit.
        /// </summary>
        public decimal CurrDeposit { get; set; }

        /// <summary>
        /// Gets or sets the origin date.
        /// </summary>
        public DateTime? OrigDate { get; set; }

        /// <summary>
        /// Gets or sets the origin tender.
        /// </summary>
        [StringLength(1)]
        public string OrigTender { get; set; }

        /// <summary>
        /// Gets or sets the authentication buyer.
        /// </summary>
        [StringLength(15)]
        public string AuthBuyer { get; set; }

        /// <summary>
        /// Gets or sets the customer job no.
        /// </summary>
        [StringLength(20)]
        public string CustJobNo { get; set; }

        /// <summary>
        /// Gets or sets the purchase order number.
        /// </summary>
        [StringLength(20)]
        public string PONumber { get; set; }

        /// <summary>
        /// Gets or sets the order status.
        /// </summary>
        [StringLength(1)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or sets the order type.
        /// </summary>
        [StringLength(1)]
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or sets the opportunity.
        /// </summary>
        [StringLength(40)]
        public string Opportunity { get; set; }

        /// <summary>
        /// Gets or sets the between streets.
        /// </summary>
        [StringLength(50)]
        public string BetweenStreets { get; set; }

        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        [StringLength(1)]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the rec status.
        /// </summary>
        [StringLength(1)]
        public string RecStatus { get; set; }

        /// <summary>
        /// Gets or sets the Cobertura.
        /// </summary>
        public string Cobertura { get; set; }

        /// <summary>
        /// Gets or sets the type of sale.
        /// </summary>
        public byte TypeOfSale { get; set; }

        /// <summary>
        /// Gets or sets the TOS.
        /// </summary>
        [StringLength(2)]
        public string TOS { get; set; }

        /// <summary>
        /// Gets or sets the pre checkout card no.
        /// </summary>
        [StringLength(19)]
        public string PreCheckoutCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        [StringLength(10)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the SCC id.
        /// </summary>
        public long? SccId { get; set; }

        /// <summary>
        /// Gets or sets the outside.
        /// </summary>
        public int? OutsideSlpn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether was validated at pos.
        /// </summary>
        public bool WasValidatedAtPOS { get; set; }

        /// <summary>
        /// Gets or sets the last validation date.
        /// </summary>
        public DateTime? LastValidationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is read only.
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the definition id.
        /// </summary>
        public int? DefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the order definition.
        /// </summary>
        public virtual OrderDefinitionEntity OrderDefinition { get; set; }

        /// <summary>
        /// Gets or sets the pricing agreement.
        /// </summary>
        public virtual PricingAgreementEntity PricingAgreement { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual CustomerEntity Customer { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual CustomerEntity DeliveryCustomer { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        public virtual EmployeeEntity Employee { get; set; }

        public virtual EmployeeEntity CommEmployee { get; set; }

        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }

        /// <summary>
        /// Gets or sets the special price requests.
        /// </summary>
        public virtual ICollection<SpecialPriceRequestEntity> SpecialPriceRequests { get; set; }

        /// <summary>
        /// Gets or sets the install requests.
        /// </summary>
        public virtual ICollection<InstallationRequestEntity> InstallationRequests { get; set; }

        /// <summary>
        /// Gets or sets the state ship to.
        /// </summary>
        public virtual StateEntity ShipToState { get; set; }

        /// <summary>
        /// Gets or sets the state sold to.
        /// </summary>
        public virtual StateEntity SoldToState { get; set; }

        /// <summary>
        /// Gets or sets the resale.
        /// </summary>
        public virtual ICollection<ResaleEntity> Resales { get; set; }

        /// <summary>
        /// Gets or sets the installation alerts.
        /// </summary>
        public virtual ICollection<InstallationAlertEntity> InstallationAlerts { get; set; }
        #endregion

        /// <summary>
        /// Gets or sets the deliver type.
        /// </summary>
        [StringLength(1)]
        public string DeliverType { get; set; }

        /// <summary>
        /// Gets or sets the order total.
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// Gets or sets the tran date.
        /// </summary>
        public DateTime? TranDate { get; set; }

        /// <summary>
        /// Gets or sets the commiss emp.
        /// </summary>
        public int CommissEmp { get; set; }

        /// <summary>
        /// Gets or sets the copy source.
        /// </summary>
        public string CopySource { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether printed.
        /// </summary>
        public bool Printed { get; set; }

        /// <summary>
        /// Gets or sets the receive name.
        /// </summary>
        public string ReceiveName { get; set; }

        /// <summary>
        /// Gets or sets the tax code.
        /// </summary>
        [StringLength(12)]
        public string TaxCode { get; set; }

        public byte OrderTypeCd { get; set; }

        [NotMapped]
        public string ErrorService
        {
            get; set;
        }

        #region NonActualField
        //public string EmployeeID { get; set; }
        //public string Demographic { get; set; }
        //public byte? DiscountType { get; set; }
        //public byte? EotDiscount { get; set; }
        //public byte? TaxExmptType { get; set; }
        //public decimal? NonTaxFood { get; set; }
        //public decimal? Payments { get; set; }
        //public decimal? RoaDiscount { get; set; }
        //public decimal? LineDiscount { get; set; }
        //public decimal? SpreadDisc { get; set; }
        //public decimal? PriceAllow { get; set; }
        //public decimal? OrderDisc { get; set; }
        //public decimal? CostOfGoods { get; set; }
        //public string SoldMidInit { get; set; }
        //public decimal? DistanceShip { get; set; }
        //public string ContactInfo { get; set; }
        //public string POAuthInitls { get; set; }
        //public bool? DiscountFlag { get; set; }
        //public decimal? DiscPercent { get; set; }
        //public short? DeliverCount { get; set; }
        //public string ReserveFlag { get; set; }
        //public decimal? SprdDiscPcnt { get; set; }
        //public byte? SpreadDiscTp { get; set; }
        //public decimal? AddTaxAmount { get; set; }
        //public int? InvoiceNo { get; set; }
        //public string ReferenceNo__1 { get; set; }
        //public string ReferenceNo__2 { get; set; }
        //public string ReferenceNo__3 { get; set; }
        //public byte? OperatMode { get; set; }
        //public decimal? TOSDiscPerc { get; set; }
        //public int? OrigSlPerson { get; set; }
        //public string AuthSigner { get; set; }
        //public bool? Authorized { get; set; }
        //public bool? CustomerHelp { get; set; }
        //public string DriverLicense { get; set; }
        //public string CommissPayID { get; set; }
        //public short? RetailRegID { get; set; }
        //public int? OrigInvoice { get; set; }
        //public decimal? AltTaxDisc { get; set; }
        //public decimal? FRegTaxMdse { get; set; }
        //public decimal? FRegTaxNonMd { get; set; }
        //public decimal? FRegTaxDisc { get; set; }
        //public decimal? FRegTaxTotal { get; set; }
        //public decimal? FAltTaxMdse { get; set; }
        //public decimal? FAltTaxNonMd { get; set; }
        //public decimal? FAltTaxDisc { get; set; }
        //public decimal? FAltTaxTotal { get; set; }
        //public decimal? FNonTaxMdse { get; set; }
        //public decimal? FNonTaxNonMd { get; set; }
        //public decimal? FNonTaxDisc { get; set; }
        //public string CopyFile { get; set; }
        //public int? MembershipNo { get; set; }
        //public short? ECDCode { get; set; }
        //public int? GPMngeApproval { get; set; }
        //public decimal? PrintedTotal { get; set; }
        //public string CommCustomer { get; set; }
        //public string TaxFolio { get; set; }
        //public bool? CreateMethod { get; set; }
        //public byte? FreightFreeReason { get; set; }
        //public string FreightFreeRequest { get; set; }
        //public string FreightFreeAuth { get; set; }
        //public TimeSpan? LastMntTime { get; set; }
        //public TimeSpan? PdbupdTime { get; set; }
        //public TimeSpan? RetailTime { get; set; }
        //public TimeSpan? TrnprcTime { get; set; }
        //public string AuthCode { get; set; }
        //public bool? Taxable { get; set; }
        //public bool? SummDetFlag { get; set; }
        //public bool? PdbupdFlag { get; set; }
        //public bool? RetailFlag { get; set; }
        //public bool? TrnprcFlag { get; set; }
        //public DateTime? DelDate { get; set; }
        //public DateTime? RecapPrtDate { get; set; }
        //public DateTime? LastMntDate { get; set; }
        //public DateTime? PdbupdDate { get; set; }
        //public DateTime? RetailDate { get; set; }
        //public DateTime? TrnprcDate { get; set; }
        //public decimal? AutoRingPymt { get; set; }
        //public decimal? RegTaxMdse { get; set; }
        //public decimal? RegTaxTotal { get; set; }
        //public decimal? TotalCost { get; set; }
        //public decimal? RegTaxDisc { get; set; }
        //public decimal? NonTaxDisc { get; set; }
        //public decimal? AltTaxTotal { get; set; }
        //public decimal? AltTaxMdse { get; set; }
        //public decimal? AltTaxNonMde { get; set; }
        //public short? FirstRegID { get; set; }
        //public int? FirstTranNo { get; set; }
        //public short? LastRegID { get; set; }
        //public int? LastTranNo { get; set; }
        //public short? DelLines { get; set; }
        //public short? ZeroLines { get; set; }
        //public short? FutLines { get; set; }
        //public byte? DiscountCode { get; set; }
        //public string AltTaxCode { get; set; }
        //public short? OrigStore { get; set; }
        //public short? OrigRegID { get; set; }
        //public int? OrigTranNo { get; set; }
        //public int? SpdSaleNo { get; set; }
        //public decimal? NonTaxMdse { get; set; }
        //public int? RetailTran { get; set; }
        #endregion
    }
}
      