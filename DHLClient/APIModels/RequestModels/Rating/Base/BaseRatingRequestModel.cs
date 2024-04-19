using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all the rating requests
    /// </summary>
    public class BaseRatingRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Here you need to define all the parties needed to ship the package
        /// </summary>
        [JsonProperty("customerDetails")]
        public CustomerDetailRequestModel? CustomerDetails { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonRequired]
        [JsonProperty("accounts")]
        public IEnumerable<AccountRequestModel>? Accounts { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Local Product code
        /// </summary>
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// Here you can define properties per package
        /// </summary>
        [JsonProperty("packages")]
        public PackageRequestModel? Packages { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseRatingRequestModel() : base()
        {

        }

        #endregion
    }
}
