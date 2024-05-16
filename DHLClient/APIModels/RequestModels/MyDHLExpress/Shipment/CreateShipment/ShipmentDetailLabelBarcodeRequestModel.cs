using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a label bracode
    /// </summary>
    public class ShipmentDetailLabelBarcodeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Position of the bespoke barcode
        /// </summary>
        /// <example>left</example>
        [JsonRequired]
        [JsonProperty("position")]
        [JsonConverter(typeof(BarcodePositionTypeToStringJsonConverter))]
        public BarcodePositionType? Position { get; set; }

        /// <summary>
        /// Please enter valid Symbology code
        /// </summary>
        [JsonRequired]
        [JsonProperty("symbologyCode")]
        [JsonConverter(typeof(SymbologyCodeToIntJsonConverter))]
        public SymbologyCode? SymbologyCode { get; set; }

        /// <summary>
        /// Please enter barcode content
        /// </summary>
        [JsonRequired]
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Please enter text below customer barcode
        /// </summary>
        [JsonRequired]
        [JsonProperty("textBelowBarcode")]
        public string? TextBelowBarcode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailLabelBarcodeRequestModel() : base()
        {

        }

        #endregion
    }
}