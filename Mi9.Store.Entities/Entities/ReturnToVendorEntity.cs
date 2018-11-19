using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    public class ReturnToVendorEntity 
    {
        public long RTVNumber { get; set; }

        public string VendorID { get; set; }

        public byte VendorSuffix { get; set; }
        
        public byte TypeId { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateClosed { get; set; }

        public string VehicleLicense { get; set; }

        public string DriverRef { get; set; }

        public string Authorizer { get; set; }

        public string RtnAuthNumber { get; set; }
    
        public bool DestroyInStore { get; set; }

        public int CreateEmplNo { get; set; }

        public int? CloseEmplNo { get; set; }

        public string Status { get; set; }

        public string RGA { get; set; }

        public string Notes { get; set; }

        public DateTime? DateCanceled { get; set; }
      
        public int? CancelEmplNo { get; set; }
      
        public int? CategoryId { get; set; }

        public virtual ReturnToVendorTypeEntity Type { get; set; }

        public virtual VendorEntity Vendor { get; set; }

        public virtual ICollection<ReturnToVendorItemEntity> Items { get; set; }
    }

}