using DHLClient.QueryArgumentConverters;

namespace DHLClient
{
    /// <summary>
    /// Arguments used for getting a shipment image
    /// </summary>
    public class ShipmentImageAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        /// <example>9356579890</example>
        [ArgumentName("shipmentTrackingNumber")]
        public long? ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// DHL Express customer shipper account number
        /// </summary>
        /// <example>123456789</example>
        [ArgumentName("shipmentAccountNumber")]
        public double? ShipmentAccountNumber { get; set; }

        /// <summary>
        /// Please provide correct document type.
        /// </summary>
        [ArgumentName("typeCode")]
        [QueryArgumentConverter<DocumentInvoiceTypeQueryArgumentConverter>]
        public DocumentInvoiceType? TypeCode { get; set; }

        /// <summary>
        /// Please provide the pickup's date in YYYY-MM format
        /// </summary>
        [ArgumentName("pickupYearAndMonth")]
        public string? PickupYearAndMonth { get; set; }

        /// <summary>
        /// Please provide the document image encoding format in pdf or tiff format
        /// </summary>
        [ArgumentName("encodingFormat")]
        [QueryArgumentConverter<EncodingFormatQueryArgumentConverter>]
        public EncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Option to return all the document images in a single PDF file
        /// </summary>
        [ArgumentName("allInOnePDF")]
        public bool? IsAllInOnePDF { get; set; }

        /// <summary>
        /// Option to return all the document images in a compressed package
        /// </summary>
        [ArgumentName("compressedPackage")]
        public bool? IsCompressedPackage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentImageAPIArgs() : base()
        {

        }

        #endregion    
    }
}