using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a content package
    /// </summary>
    public class ShipmentDetailContentPackageRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please contact your DHL Express representative if you wish to use a DHL specific package otherwise ignore this element
        /// </summary>
        /// <example>2BP</example>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(PackagingTypeToStringJsonConverter))]
        public PackagingType? TypeCode { get; set; }

        /// <summary>
        /// The weight of the package.
        /// </summary>
        /// <example>22.501</example>
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Dimensions of the package
        /// </summary>
        [JsonProperty("dimensions")]
        public ShipmentDetailDimensionsRequestModel? Dimensions { get; set; }

        /// <summary>
        /// Here you can declare your customer references for each package
        /// </summary>
        [JsonProperty("customerReferences")]
        public IEnumerable<CustomerPackageReferenceRequestModel>? CustomerReferences { get; set; }

        /// <summary>
        /// Identifiers section is on the package level where you can optionaly provide a DHL Express waybill number. 
        /// This has to be enabled by your DHL Express IT contact.
        /// </summary>
        [JsonProperty("identifiers")]
        public IEnumerable<ShipmentDetailIdentifiersRequestModel>? Identifiers { get; set; }

        /// <summary>
        /// Please enter description of content for each package
        /// </summary>
        /// <example>Piece content description</example>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This allows you to define up to two bespoke barcodes on the DHL Express Transport label. 
        /// To use this feature please set outputImageProperties/imageOptions/templateName as ECOM26_84CI_003 for typeCode=label
        /// </summary>
        [JsonProperty("labelBarcodes")]
        public IEnumerable<ShipmentDetailLabelBarcodeRequestModel>? LabelBarcodes { get; set; }

        /// <summary>
        /// This allows you to enter up to two bespoke texts on the DHL Express Transport label.
        /// To use this feature please set outputImageProperties/imageOptions/templateName as ECOM26_84CI_003 for typeCode=label
        /// </summary>
        [JsonProperty("labelText")]
        public IEnumerable<ShipmentDetailLabelTextRequestModel>? LabelText { get; set; }

        /// <summary>
        /// Please enter additional customer description
        /// </summary>
        /// <example>bespoke label description</example>
        [JsonProperty("labelDescription")]
        public string? LabelDescription { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailContentPackageRequestModel() : base()
        {

        }

        #endregion
    }
}