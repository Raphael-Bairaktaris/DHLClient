using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a product and service
    /// </summary>
    public class ProductAndServiceRequestModel : ValueAddedServiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonRequired]
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Local Product code
        /// </summary>
        [JsonRequired]
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

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