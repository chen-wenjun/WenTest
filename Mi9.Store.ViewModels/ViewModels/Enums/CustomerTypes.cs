using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    /// <summary>
    /// The customer types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerTypes
    {
        /// <summary>
        /// The default value.
        /// </summary>
        Default = 0,

        /// <summary>
        /// The professional customer.
        /// </summary>
        Pro = 'C',

        /// <summary>
        /// The professional customer with AR account.
        /// </summary>
        ProWithAr = 'D',

        /// <summary>
        /// The employee.
        /// </summary>
        Employee = 'E',

        /// <summary>
        /// The regular (normal) customer.
        /// </summary>
        Regular = 'N'
    }
}