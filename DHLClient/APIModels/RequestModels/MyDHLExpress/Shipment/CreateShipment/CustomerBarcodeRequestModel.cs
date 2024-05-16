using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer barcode
    /// </summary>
    public class CustomerBarcodeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter barcode content
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Please enter text below customer barcode
        /// </summary>
        [JsonProperty("textBelowBarcode")]
        public string? TextBelowBarcode { get; set; }

        /// <summary>
        /// Please enter valid symbology code
        /// </summary>
        [JsonRequired]
        [JsonProperty("symbologyCode")]
        public string? SymbologyCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerBarcodeRequestModel() : base()
        {

        }

        #endregion
    }
}