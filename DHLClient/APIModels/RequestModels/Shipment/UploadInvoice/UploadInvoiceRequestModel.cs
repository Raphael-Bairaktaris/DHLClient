using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for uploading an invoice
    /// </summary>
    public class UploadInvoiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The planned shipment date for the provided shipmentTrackingNumber. 
        /// The date must be in the format: YYYY-MM-DD
        /// </summary>
        /// <example>2020-04-20</example>
        [JsonProperty("plannedShipDate")]
        public DateOnly PlannedShipDate { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment. 
        /// Note: accounts/0/number with typeCode 'shipper' is mandatory if using POST method and no shipmentTrackingNumber is provided in request.
        /// </summary>
        [JsonProperty("accounts")]
        public IEnumerable<AccountRequestModel>? Accounts { get; set; }

        /// <summary>
        /// Here you can define all the properties related to the content of the prospected shipment
        /// </summary>
        [JsonProperty("content")]
        public UploadInvoiceContentRequestModel Content { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadInvoiceRequestModel() : base()
        {

        }

        #endregion
    }
}
