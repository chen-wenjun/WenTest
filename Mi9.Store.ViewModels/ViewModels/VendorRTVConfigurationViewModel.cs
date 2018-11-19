using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class VendorRTVConfigurationViewModel
    {
	    public string VendorId { get; set; }
        public byte VendorSuffix { get; set; }
        public short RtnType { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool UseMainContact { get; set; }
        public bool RetAuth { get; set; }
        public bool PartsRe { get; set; }
        public bool Inspec { get; set; }
        public string TypeOfFreight { get; set; }
        public DateTime MntDate { get; set; }
    }
}
