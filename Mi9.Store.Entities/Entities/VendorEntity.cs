using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class VendorEntity
    {
        public string VendorId { get; set; }

        public byte VendorSuffix { get; set; }

        public string VendorName { get; set; }

        public bool SpecificationsRequired { get; set; }

        public string VendStatus { get; set; }

        public short? VendNegoDays { get; set; }

        public string Phone { get; set; }

        public string Contact { get; set; }

        public string ContactPosition { get; set; }

        public string SalesmanPosition { get; set; }

        public string SalesmanEmailAddr { get; set; }

        public string ShipInst { get; set; }

        public string SpecInst1 { get; set; }

        public string SpecInst2 { get; set; }

        public string EmailAddr { get; set; }

        public int? MinCollUnits { get; set; } //VendorMinimumQuantity

        public int? MinCollDollr { get; set; } //VendorMinimumCost

        public string PayMethodCode { get; set; }

        public string SettleTermCode { get; set; }

        public short LeadTime { get; set; }

        public short? DepartmentId { get; set; }

        public virtual DepartmentEntity Department { get; set; }

        public virtual ICollection<ItemSkuEntity> ItemSkus { get; set; }

        public ICollection<PurchaseOrderEntity> PurchaseOrders { get; set; }

        public virtual ICollection<ItemVendorEntity> VendorItems { get; set; }

        public PaymentMethodEntity PaymentMethod { get; set; }

        public InvoiceTermEntity InvoiceTerms { get; set; }

        public FobTermEntity FobTerm { get; set; }

        public int? EmployeeNo { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        public int? MinCollVolum { get; set; }

        public int? MinCollWgt { get; set; }

        public virtual ICollection<ReturnToVendorEntity> ReturnToVendors { get; set; }

        public virtual ICollection<ShipmentEntity> Shipments { get; set; }

        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string ShipType { get; set; }
        public decimal? FreightPct { get; set; }

        public virtual VendorRTVConfigurationEntity RTVConfiguration { get; set; }

        #region LegacyFields

        public string FOBCode { get; set; }

        public string OrderInst { get; set; }

        public string SalesName { get; set; }

        public string SalesPhone { get; set; }

        public DateTime? NextOrdrDate { get; set; }

        public bool OrderCycle { get; set; }

        public string ExtenFax { get; set; }
 
        public short? Destcode { get; set; }

        public short OrderSchDays { get; set; }

        #endregion

        public string SoContactName { get; set; }
        public string SoContactPosition { get; set; }
        public string SoContactPhone { get; set; }
        public string SoContactEmailAddr { get; set; }

        public string SoSalesName { get; set; }
        public string SoSalesmanPosition { get; set; }
        public string SoSalesPhone { get; set; }
        public string SoSalesmanEmailAddr { get; set; }
    }
}
