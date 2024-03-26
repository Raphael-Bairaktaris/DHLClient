using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a customer barcode
    /// </summary>
    public class ShipmentCustomerBarcodeRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Content"/> property
        /// </summary>
        private string? mContent;

        /// <summary>
        /// The member of the <see cref="TextBelowBarcode"/> property
        /// </summary>
        private string? mTextBelowBarcode;

        /// <summary>
        /// The member of the <see cref="SymbologyCode"/> property
        /// </summary>
        private string? mSymbologyCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// Please enter barcode content
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public string Content
        {
            get => mContent ?? string.Empty;
            set => mContent = value;
        }

        /// <summary>
        /// Please enter text below customer barcode
        /// </summary>
        [JsonProperty("textBelowBarcode")]
        public string TextBelowBarcode
        {
            get => mTextBelowBarcode ?? string.Empty;
            set => mTextBelowBarcode = value;
        }

        /// <summary>
        /// Please enter valid symbology code
        /// </summary>
        [JsonRequired]
        [JsonProperty("symbologyCode")]
        public string SymbologyCode
        {
            get => mSymbologyCode ?? string.Empty;
            set => mSymbologyCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCustomerBarcodeRequestModel() : base()
        {

        }

        #endregion
    }
}