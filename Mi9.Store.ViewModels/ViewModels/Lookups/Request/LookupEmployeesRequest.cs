using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupEmployeesRequest : LookupRequest
    {
        public string PayrollId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }
        public IEnumerable<bool?> TaBadge { get; set; }
    }
}