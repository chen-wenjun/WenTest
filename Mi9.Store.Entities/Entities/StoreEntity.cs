using System.Collections.Generic;
using System.Globalization;

namespace Mi9.Store.Entities.Entities
{
    public class StoreEntity
    {
        public bool StoreType { get; set; }

        public short StoreNumber { get; set; }

        public byte? Division { get; set; }

        public string StoreName { get; set; }

        public string ManagerName { get; set; }


        public string TaxCode { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public string Phone { get; set; }

        public string DistrictCode { get; set; }

        public string EmailAddr { get; set; }

        public string Status { get; set; }

        public string FloatCashier { get; set; }

        public virtual DistrictEntity District { get; set; }

        public virtual TaxEntity Tax { get; set; }

        public virtual StateEntity State { get; set; }

        public virtual ICollection<DestinationStoreEntity> DestinationStoreRequested { get; set; }

        public virtual ICollection<DestinationStoreEntity> DestinationStoreSourced { get; set; }
        

        public string CompoundName
        {
            get
            {
                return StoreNumber.ToString(CultureInfo.InvariantCulture) + " " + StoreName;
            }
        }
    }
}