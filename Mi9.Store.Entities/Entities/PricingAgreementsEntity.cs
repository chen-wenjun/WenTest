using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The pricing agreement entity.
    /// </summary>
    public class PricingAgreementEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingAgreementEntity"/> class.
        /// </summary>
        public PricingAgreementEntity()
        {
            Status = "New";
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status comments.
        /// </summary>
        public string StatusComments { get; set; }

        /// <summary>
        /// Gets or sets the type of work.
        /// </summary>
        public string TypeOfWork { get; set; }

        /// <summary>
        /// Gets or sets the status of work.
        /// </summary>
        public string StatusOfWork { get; set; }

        /// <summary>
        /// Gets or sets the estimated start date.
        /// </summary>
        public DateTime EstimatedStartDate { get; set; }

        /// <summary>
        /// Gets or sets the estimated end date.
        /// </summary>
        public DateTime EstimatedEndDate { get; set; }

        /// <summary>
        /// Gets or sets the probably success.
        /// </summary>
        public byte ProbablySuccess { get; set; }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the credit status.
        /// </summary>
        public string CreditStatus { get; set; }

        /// <summary>
        /// Gets or sets the available credit.
        /// </summary>
        public decimal AvailableCredit { get; set; }

        /// <summary>
        /// Gets or sets the consumption period.
        /// </summary>
        public Int16 ConsumptionPeriod { get; set; }

        /// <summary>
        /// Gets or sets the consumption start date.
        /// </summary>
        public DateTime? ConsumptionStartDate { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or sets the deliver name.
        /// </summary>
        public string DeliverName { get; set; }

        /// <summary>
        /// Gets or sets the delivery method.
        /// </summary>
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets the receiver name.
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// Gets or sets the receiver phone.
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// Gets or sets the quatation date.
        /// </summary>
        public DateTime QuatationDate { get; set; }

        /// <summary>
        /// Gets or sets OAT Conditions: SCC Due Date.
        /// </summary>
        public DateTime? SccDueDate { get; set; }

        /// <summary>
        /// Gets or sets OAT Conditions: Paperwork Target Date.
        /// </summary>
        public DateTime? PaperworkTargetDate { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public virtual SccAddressEntity Address { get; set; }

        /// <summary>
        /// Gets or sets the scc requirements.
        /// </summary>
        public virtual SccRequirementEntity Requirement { get; set; }

        /// <summary>
        /// Gets or sets the receiving hours.
        /// </summary>
        public virtual ReceivingHoursEntity ReceivingHours { get; set; }

        /// <summary>
        /// Gets or sets the scc items.
        /// </summary>
        public virtual ICollection<SccItemEntity> SccItems { get; set; }

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        public virtual ICollection<OrderEntity> Orders { get; set; } 

        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the sub key.
        /// </summary>
        public short SubKey { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual CustomerEntity Customer { get; set; }

        /// <summary>
        /// Gets or sets the EmployeeNo.
        /// </summary>
        public int? EmployeeNo { get; set; }

        /// <summary>
        /// Gets or sets the Employee Entity.
        /// </summary>
        public virtual EmployeeEntity Employee { get; set; }

        /// <summary>
        /// Gets or sets the AuthBuyer.
        /// </summary>
        public string AuthBuyer { get; set; }

        /// <summary>
        /// Gets or sets the AuthBuyer.
        /// </summary>
        public string PONumber { get; set; }
    }
}