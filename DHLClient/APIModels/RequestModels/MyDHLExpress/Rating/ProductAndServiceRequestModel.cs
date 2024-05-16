using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a product and service
    /// </summary>
    public class ProductAndServiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        /// <example>P</example>
        [JsonRequired]
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Local Product code
        /// </summary>
        /// <example>P</example>
        [JsonRequired]
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// Please use if you wish to filter the response by value added services
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public IEnumerable<ValueAddedServiceRequestModel>? ValueAddedServices { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductAndServiceRequestModel() : base()
        {

        }

        #endregion
    }
}