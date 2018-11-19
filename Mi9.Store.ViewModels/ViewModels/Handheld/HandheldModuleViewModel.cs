using MI9.HDM.Store.BackOffice.Core.Handheld;

namespace Mi9.Store.ViewModels.ViewModels.Handheld
{
    /// <summary>
    /// View/Model for the HandheldModule entity
    /// </summary>
    public class HandheldModuleViewModel
    {
        /// <summary>
        /// Handheld Module Type
        /// </summary>
        public HandheldModuleEnum ModuleType { get; set; }

        /// <summary>
        /// Handheld Module Url
        /// </summary>
        public string ModuleUrl { get; set; }

        /// <summary>
        /// Handheld Module Description
        /// </summary>
        public string Description { get; set; }
    }
}
