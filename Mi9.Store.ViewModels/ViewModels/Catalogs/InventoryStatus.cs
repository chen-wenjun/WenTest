using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Catalogs
{
    public static class InventoryStatus
    {
        static public Dictionary<string, string> Status = new Dictionary<string, string>
	    {
	        {"N", "New"},
	        {"C", "Closed"},
	        {"O", "Open"}
	    };

        public static string New { get { return "N"; } }
        public static string Closed { get { return "C"; } }
        public static string Open { get { return "O"; } }
    }
}
