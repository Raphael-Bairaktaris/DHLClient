using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a postal address
    /// </summary>
    public class ShipmentCustomerDetailPostalAddressRequestModel : ShipperDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter your state or province name
        /// </summary>
        /// <example>Central Bohemia</example>
        [JsonProperty("provinceName")]
        public string? ProvinceName { get; set; }

        /// <summary>
        /// Please enter your country name
        /// </summary>
        [JsonProperty("countryName")]
        public string? CountryName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCustomerDetailPostalAddressRequestModel() : base()
        {

        }

        #endregion
    }
}