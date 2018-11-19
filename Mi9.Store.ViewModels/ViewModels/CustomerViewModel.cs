using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.Converters;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CustomerViewModel : CustomerBaseViewModel
    {
        /// <summary>
        /// Gets or sets the home phone.
        /// </summary>
        [JsonProperty(PropertyName = "homePhone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or sets the business phone.
        /// </summary>
        [JsonProperty(PropertyName = "businessPhone")]
        public string BusinessPhone { get; set; }

        /// <summary>
        /// Gets or sets the fax number.
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the store remarks.
        /// </summary>
        [JsonProperty(PropertyName = "remarks")]
        public string StoreRemarks { get; set; }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        [JsonProperty(PropertyName = "paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        [JsonProperty(PropertyName = "sinceDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the last purchase date.
        /// </summary>
        [JsonProperty(PropertyName = "lastPurchaseDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? LastPurchaseDate { get; set; }

        /// <summary>
        /// Gets or sets the last purchase sum.
        /// </summary>
        [JsonProperty(PropertyName = "lastPurchaseSum")]
        public decimal? LastPurchaseSum { get; set; }

        /// <summary>
        /// Gets or sets the since amount.
        /// </summary>
        [JsonProperty(PropertyName = "sinceSum")]
        public decimal SinceAmount { get; set; }

        /// <summary>
        /// Gets or sets the gecc remarks.
        /// </summary>
        [JsonProperty(PropertyName = "geccRemarks")]
        public string GECCRemarks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether po required.
        /// </summary>
        [JsonProperty(PropertyName = "poRequired")]
        public bool PORequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether buyer required.
        /// </summary>
        [JsonProperty(PropertyName = "buyerRequired")]
        public bool BuyerRequired { get; set; }

        /// <summary>
        /// Gets or sets the cheque.
        /// </summary>
        [JsonProperty(PropertyName = "cheque")]
        public string Cheque { get; set; }

        /// <summary>
        /// Gets or sets the cobertura.
        /// </summary>
        [JsonProperty(PropertyName = "cobertura")]
        public string Cobertura { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        [JsonProperty(PropertyName = "contacts")]
        public List<string> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        [JsonProperty(PropertyName = "projects")]
        public List<CustomerProjectsViewModel> Projects { get; set; }

        /// <summary>
        /// Gets or sets the available credit.
        /// </summary>
        [JsonProperty(PropertyName = "availableCredit")]
        public decimal AvailableCredit { get; set; }

        /// <summary>
        /// Gets or sets the available credits.
        /// </summary>
        [JsonProperty(PropertyName = "availableCredits")]
        public string AvailableCredits { get; set; }

        /// <summary>
        /// Gets or sets the tax id.
        /// </summary>
        [JsonProperty(PropertyName = "taxId")]
        public string TaxId { get; set; }

        /// <summary>
        /// Gets or sets the job state id.
        /// </summary>
        [JsonProperty(PropertyName = "jobStateId")]
        public string JobStateId { get; set; }

        /// <summary>
        /// Gets or sets the curp.
        /// </summary>
        [JsonProperty(PropertyName = "curp")]
        public string CURP { get; set; }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public TaxViewModel Tax { get; set; }

        /// <summary>
        /// Gets or sets the job state.
        /// </summary>
        [JsonProperty(PropertyName = "jobState")]
        public StateViewModel JobState { get; set; }

        /// <summary>
        /// Gets or sets the customer type.
        /// </summary>
        [JsonProperty(PropertyName = "customerType")]
        public CustomerTypes CustomerType { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public List<AddressViewModel> Addresses { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has scc agreement.
        /// </summary>
        [JsonProperty(PropertyName = "hasScc")]
        public bool HasSccAgreement { get; set; }

        /// <summary>
        /// Gets a value indicating whether is regular.
        /// </summary>
        [JsonProperty(PropertyName = "isRegular")]
        public bool IsRegular
        {
            get
            {
                return CustomerType == CustomerTypes.Regular;
            }
        }

        [JsonProperty(PropertyName = "statusCRM")]
        public string ValidCrmStatus { get; set; }

        [JsonProperty(PropertyName = "errorService")]
        public string ErrorService { get; set; }

        [JsonProperty(PropertyName = "cash")]
        public bool Cash { get; set; }
    }
}