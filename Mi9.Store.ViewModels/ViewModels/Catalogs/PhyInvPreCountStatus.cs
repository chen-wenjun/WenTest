using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Catalogs
{
    public class PhyInvPreCountStatus
    {
        static public Dictionary<string, string> Status = new Dictionary<string, string>
	    {
	        {"N", "New"},
	        {"C", "Closed"},
	        {"P", "To Audit"},
	        {"A", "Audited"}
	    };

        public static string New { get { return "N"; } }
        public static string Closed { get { return "C"; } }
        public static string ToAudit { get { return "P"; } }
        public static string Audited { get { return "A"; } }
    }
}
