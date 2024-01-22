using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipper postal address response
    /// </summary>
    public class ShipperPostalAddressResponseModel : AddressDetailsResponseModel
    {
        #region

        /// <summary>
        /// The region in which the locality and which is in the country
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("provinceCode")]
        public CountryCode ProvinceCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipperPostalAddressResponseModel() : base()
        {

        }

        #endregion
    }
}