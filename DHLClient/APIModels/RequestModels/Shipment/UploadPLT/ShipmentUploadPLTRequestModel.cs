using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests for creating or updating an upload paperless trade 
    /// </summary>
    public class ShipmentUploadPLTRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The planned shipping date
        /// </summary>
        /// <example>2020-04-20</example>
        [JsonRequired]
        [JsonProperty("originalPlannedShippingDate")]
        public DateOnly OriginallyPlannedShippingDate { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonProperty("accounts")]
        public IEnumerable<AccountRequestModel>? Accounts { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        /// <example>D</example>
        [JsonRequired]
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// This section is to support multiple base64 encoded string with the image of export documentation
        /// for Paperless Trade images. When an invalid base64 encoded string is provided, an error message will be returned
        /// </summary>
        [JsonProperty("documentImages")]
        public IEnumerable<ShipmentDetailDocumentImageRequestModel>? DocumentImages { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentUploadPLTRequestModel() : base()
        {

        }

        #endregion
    }
}
