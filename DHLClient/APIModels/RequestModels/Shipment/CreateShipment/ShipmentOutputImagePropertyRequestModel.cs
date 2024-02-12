using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an output image property
    /// </summary>
    public class ShipmentOutputImagePropertyRequestModel
    {
        #region Public Property

        /// <summary>
        /// Printer DPI Resolution for X-axis and Y-axis (in DPI) for transport label and waybill document output
        /// </summary>
        [JsonProperty("printerDPI")]
        public double PrinterDPI { get; set; }

        /// <summary>
        /// Customer barcodes to be printed on supported transport label templates
        /// </summary>
        [JsonProperty("customerBarcodes")]
        public IEnumerable<ShipmentCustomerBarcodeRequestModel> CustomerBarcodes { get; set; }

        /// <summary>
        /// Customer Logo Image to be printed on transport label
        /// </summary>
        [JsonProperty("customerLogos")]
        public ShipmentCustomerLogoRequestModel CustomerLogos { get; set; }

        /// <summary>
        /// Please provide the format of the output documents. Note that invoice and shipment receipt will always come back as PDF
        /// </summary>
        [JsonProperty("encodingFormat")]
        [JsonConverter(typeof(EncodingFormatToStringJsonConverter))]
        public EncodingFormat EncodingFormat { get; set; }

        /// <summary>
        /// Here the image options are defined for label, waybillDoc, invoice, QRcode and shipment receipt
        /// </summary>
        [JsonProperty("imageOptions")]
        public IEnumerable<ShipmentImageOptionRequestModel> ImageOptions { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentOutputImagePropertyRequestModel() : base()
        {

        }

        #endregion
    }
}