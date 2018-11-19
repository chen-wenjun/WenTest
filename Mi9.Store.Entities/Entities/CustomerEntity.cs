using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mi9.Store.Entities.Entities
{
    public class CustomerEntity
    {
        public CustomerEntity()
        {
            LastName = "Generic";
            FirstName = "Customer";
            MiddleInit = " ";
            BusinessName = "Generic Customer";
            ChargeAllow = false;
            JobCity = string.Empty;
            JobZip = string.Empty;
            CustStatus = "A";
            Type = "D";
            AuthSigner = "Y";
            City = "test city";
            CreditCode = "G";
            Gender = "M";
            PORequired = "Y";
            Zip = "123456";
            CkPrivilege = true;
            JobStateId = "AGS";
            StateId = "AGS";
            TaxId = "1";
        }

        public long CustomerId { get; set; }
       
        public short SubKey { get; set; }
        
        public string FirstName { get; set; }

        public string MiddleInit { get; set; }

        public string LastName { get; set; }

        
        public string BusinessName { get; set; }

        public string Addr1 { get; set; }

        public string Addr2 { get; set; }

        public string Addr3 { get; set; } // addr3 is the country

        public string City { get; set; }

        public string Zip { get; set; }

        public string PhoneNumber { get; set; }

        public string AltPhoneNumb { get; set; }

        public string TaxFolio { get; set; }
       
        public string FaxNumber { get; set; }
       
        public string StoreRemarks { get; set; }

        public string Type { get; set; }

        public string POReference { get; set; }

        public DateTime? SetUpDate { get; set; }

        public string GECCComments { get; set; }

        public string PORequired { get; set; }

        public string AuthSigner { get; set; }

        public string AuthBuyers__1 { get; set; }

        public string AuthBuyers__2 { get; set; }

        public string AuthBuyers__3 { get; set; }

        public string AuthBuyers__4 { get; set; }

        public string AuthBuyers__5 { get; set; }

        public string AuthBuyers__6 { get; set; }

        public string AuthBuyers__7 { get; set; }

        public string AuthBuyers__8 { get; set; }

        public string AuthBuyers__9 { get; set; }

        public string AuthBuyers__10 { get; set; }


        public int? SalesmanNo { get; set; }
        public decimal? Discount { get; set; }
       
        public string Contact { get; set; }
        public DateTime? CreditDate { get; set; }
        public string DBRating { get; set; }
        public decimal? ApprCredLim { get; set; }
        public decimal? ARBalance { get; set; }
        public decimal? ARCurrent { get; set; }
        public short? NumbOpenOrd { get; set; }
        public byte? TaxExReason { get; set; }
        public int CreditLimit { get; set; }
        public string TaxExNumber { get; set; }
      
        public string CreditCode { get; set; }
        public bool CkPrivilege { get; set; }
        
        public bool? LoyaltyPtsFlag { get; set; }
        public DateTime? Anniversary { get; set; }
        public byte? PriceCode { get; set; }
        public short? PrimaryStore { get; set; }
        public bool? LienLaw { get; set; }
       
        public byte? OffLineCode { get; set; }
        public string DriverLicense { get; set; }
        public bool? ChargeAllow { get; set; }
        public bool? MailList { get; set; }
        public DateTime? TaxExExp { get; set; }
        public DateTime? LastChgDate { get; set; }
        public bool? CustomerStatus { get; set; }
        public bool? EmployeeFlag { get; set; }
        public bool? Downloaded { get; set; }
        public string EmailAddr { get; set; }
        public bool? InvoiceHold { get; set; }
        public string WebAddr { get; set; }

        public short? BirthMMDD { get; set; }
        public string Gender { get; set; }
        public decimal? RenewalAmount { get; set; }
        public decimal? LoyaltyPts { get; set; }
        public decimal? TotalIssued { get; set; }
        public bool? OptEmail { get; set; }
        public bool? OptPhone { get; set; }
        public bool? OptFax { get; set; }
        public bool? OptText { get; set; }
        public bool? OptShare { get; set; }
        public bool? EmailRcpt { get; set; }
      
        public string PCIComments__1 { get; set; }
        public string PCIComments__2 { get; set; }
        public string JobAddr1 { get; set; }
        public string JobAddr2 { get; set; }
        public string JobCity { get; set; }
       
        public string JobZip { get; set; }
        public string OutSideSlsID { get; set; }
        public string CustStatus { get; set; }
        public string LastTranType { get; set; }
        public string DiscountCode { get; set; }
        public bool? Taxable { get; set; }
        public DateTime? LastMntDate { get; set; }
        public DateTime? LastRevwDate { get; set; }
        public DateTime? BalMaintDate { get; set; }
        public DateTime? LastTranDate { get; set; }
        public DateTime? LastRefresh { get; set; }
        public decimal? SaleSinceBal { get; set; }
        public decimal? LastTransAmt { get; set; }
        public short? ECDCode { get; set; }
        public byte? CustTypeNo { get; set; }
        public short? Terms { get; set; }
        public string PayDays__1 { get; set; }
        public string PayDays__2 { get; set; }
        public string PayDays__3 { get; set; }
        public string PayDays__4 { get; set; }
        public string PayDays__5 { get; set; }
        public string PayDays__6 { get; set; }
        public string PayDays__7 { get; set; }
        public string ReviDays__1 { get; set; }
        public string ReviDays__2 { get; set; }
        public string ReviDays__3 { get; set; }
        public string ReviDays__4 { get; set; }
        public string ReviDays__5 { get; set; }
        public string ReviDays__6 { get; set; }
        public string ReviDays__7 { get; set; }
        public string PayTime { get; set; }
        public string ReviTime { get; set; }
        public bool? Cash { get; set; }
        public DateTime? StatusDate { get; set; }

        public virtual Collection<OrderEntity> Orders { get; set; }

        public virtual Collection<OrderEntity> DeliveryOrders { get; set; }

        public virtual ICollection<PricingAgreementEntity> Agreements { get; set; }

        public virtual ICollection<InstallationRequestEntity> InstallationRequests { get; set; }

        public string StateId { get; set; }

        public string JobStateId { get; set; }

        public string TaxId { get; set; }

        public string CURP { get; set; }

        public virtual TaxEntity Tax { get; set; }
        public virtual StateEntity JobState { get; set; }

        public virtual StateEntity State { get; set; }
    }
}