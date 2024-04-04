using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipper postal address response
    /// </summary>
    public class ShipperPostalAddressResponseModel : AddressDetailResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The region in which the locality and which is in the country
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("provinceCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
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