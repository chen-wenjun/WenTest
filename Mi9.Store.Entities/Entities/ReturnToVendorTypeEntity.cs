namespace Mi9.Store.Entities.Entities
{
    using System.Collections.Generic;

    public class ReturnToVendorTypeEntity
    {
        public byte DispCode { get; set; }

        public string Instructions { get; set; }

        public bool ReturnToVend { get; set; }

        public string RGANumber { get; set; }
     
        public bool Repair { get; set; }
      
        public bool Buyback { get; set; }
      
        public bool DestroyinStore { get; set; }

        public virtual ICollection<ReturnToVendorEntity> ReturnToVendors { get; set; }
    }
}