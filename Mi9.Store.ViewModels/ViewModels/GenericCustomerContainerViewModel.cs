using System.Configuration;

namespace Mi9.Store.ViewModels.ViewModels
{
    public static class GenericCustomerContainerViewMOdel
    {       
        public static long GenericCustomerId = long.Parse(ConfigurationManager.AppSettings["GenericCustomerId"]);
    }
}
