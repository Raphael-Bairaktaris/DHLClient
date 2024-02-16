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
        public double? PrinterDPI { get; set; }

        /// <summary>
        /// Customer barcodes to be printed on supported transport label templates
        /// </summary>
        [JsonProperty("customerBarcodes")]
        public IEnumerable<ShipmentCustomerBarcodeRequestModel>? CustomerBarcodes { get; set; }

        /// <summary>
        /// Customer Logo Image to be printed on transport label
        /// </summary>
        [JsonProperty("customerLogos")]
        public IEnumerable<ShipmentCustomerLogoRequestModel>? CustomerLogos { get; set; }

        /// <summary>
        /// Please provide the format of the output documents. Note that invoice and shipment receipt will always come back as PDF
        /// </summary>
        [JsonProperty("encodingFormat")]
        [JsonConverter(typeof(EncodingFormatToStringJsonConverter))]
        public EncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Here the image options are defined for label, waybillDoc, invoice, QRcode and shipment receipt
        /// </summary>
        [JsonProperty("imageOptions")]
        public IEnumerable<ShipmentImageOptionRequestModel>? ImageOptions { get; set; }

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output file for the Transport Label, a single PDF 
        /// or thermal output file for the Waybill document and a single PDF file consisting of Commercial Invoice and Shipment Receipt. 
        /// The default value is false, a single PDF or thermal output image file consists of Transport Label and single PDF 
        /// or thermal output image file for Waybill Document will be returned in create shipment response.
        /// </summary>
        [JsonProperty("splitTransportAndWaybillDocLabels")]
        public bool? SplitTransportAndWaybillDocLabels { get; set; }

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output image file consists of Transport Label, Waybill Document, 
        /// Shipment Receipt and Commercial Invoice.<BR> The default value is false, where a single PDF or thermal output image file consists 
        /// of Transport Label + Waybill Document and single PDF or thermal output image file for Shipment Receipt and Customs Invoice will be returned.
        /// </summary>
        [JsonProperty("allDocumentsInOneImage")]
        public bool? AllDocumentsInOneImage { get; set; }

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output image file for each page for the Transport Label and single PDF 
        /// or thermal output image file for Waybill Document will be returned in the create shipment response. The default value is false, a single PDF 
        /// or thermal output image file for each page for Transport Label and single PDF or thermal output image file for Waybill Document will be returned in create shipment response.
        /// </summary>
        [JsonProperty("splitDocumentsByPages")]
        public bool? SplitDocumentsByPages { get; set; }

        /// <summary>
        /// When set to true it will generate a single PDF or thermal output image file consisting of Transport Label + Waybill Document, a single file consist of Commercial Invoice and 
        /// a single file consist of Shipment Receipt. The default value is false, a single PDF or thermal output image file consists of Transport Label + Waybill Document and single PDF 
        /// or thermal output image file for Shipment Receipt and Customs Invoice will be returned in create shipment response.
        /// </summary>
        [JsonProperty("splitInvoiceAndReceipt")]
        public bool? SplitInvoiceAndReceipt { get; set; }

        /// <summary>
        /// When set to true it will generate a single PDF file consisting of Transport Label, Waybill Document and Shipment Receipt. The default value is false, a single PDF 
        /// or thermal output image file consists of Transport Label + Waybill Document and single PDF file for Shipment Receipt will be returned in create shipment response.
        /// </summary>
        [JsonProperty("receiptAndLabelsInOneImage")]
        public bool? ReceiptAndLabelsInOneImage { get; set; }

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