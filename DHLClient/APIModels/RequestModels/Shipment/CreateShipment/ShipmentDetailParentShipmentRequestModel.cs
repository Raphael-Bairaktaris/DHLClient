using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// requests used for creating or updating a parent shipment
    /// </summary>
    public class ShipmentDetailParentShipmentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the parent (mother) Product Code
        /// </summary>
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please provide the parent (mother) shipment's Value of Packages
        /// </summary>
        [JsonProperty("packagesCount")]
        public int? PackagesCount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailParentShipmentRequestModel() : base()
        {

        }

        #endregion
    }
}