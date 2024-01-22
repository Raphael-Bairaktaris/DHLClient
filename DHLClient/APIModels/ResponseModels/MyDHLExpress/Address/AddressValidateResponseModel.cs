using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an address validation response
    /// </summary>
    public class AddressValidateResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings { get; set; }

        /// <summary>
        /// The address
        /// </summary>
        [JsonProperty("address")]
        public AddressDetailsResponseModel Address { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressValidateResponseModel() : base()
        {

        }

        #endregion
    }
}
