using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an output image property
    /// </summary>
    public class InvoiceOutputImagePropertyRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Here the image options are defined for label, waybillDoc, invoice, receipt and QRcode
        /// </summary>
        [JsonProperty("imageOptions")]
        public IEnumerable<ImageOptionsRequestModel>? ImageOptions { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceOutputImagePropertyRequestModel() : base()
        {

        }

        #endregion
    }
}