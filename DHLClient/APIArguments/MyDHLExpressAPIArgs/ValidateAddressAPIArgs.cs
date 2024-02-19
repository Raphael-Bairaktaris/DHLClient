using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for validating an address
    /// </summary>
    public class ValidateAddressAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The delivery option types
        /// </summary>
        [ArgumentName("type")]
        public DeliveryService? Type { get; set; }

        /// <summary>
        /// A short text string code (see values defined in ISO 3166) specifying the shipment origin country
        /// </summary>
        [JsonProperty("countryCode")]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address.
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Text specifying the county name
        /// </summary>
        [JsonProperty("countyName")]
        public string? CountyName { get; set; }

        /// <summary>
        /// If set to true service will return no records when exact valid match not found
        /// </summary>
        [JsonProperty("strictValidation")]
        public bool? StrictValidation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ValidateAddressAPIArgs() : base()
        {

        }

        #endregion
    }
}
