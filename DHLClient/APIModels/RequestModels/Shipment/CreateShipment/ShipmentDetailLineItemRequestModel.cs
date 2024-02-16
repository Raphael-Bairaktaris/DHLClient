using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// 
    /// </summary>
    public class ShipmentDetailLineItemRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide line item number
        /// </summary>
        /// <example>1</example>
        [JsonRequired]
        [JsonProperty("number")]
        public int? Number { get; set; }

        /// <summary>
        /// Please provide description of the line item
        /// </summary>
        /// <example>line item description</example>
        [JsonRequired]
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Please provide unit or article price line item value
        /// </summary>
        [JsonRequired]
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Please enter information about quantity for this line item
        /// </summary>
        [JsonProperty("quantity")]
        public ShipmentDetailLineItemQuantityRequestModel? Quantity { get; set; }

        /// <summary>
        /// Please provide Commodity codes for the shipment at item line level
        /// </summary>
        [JsonProperty("commodityCodes")]
        public IEnumerable<ShipmentLineItemCommodityCodeRequestModel>? CommodityCodes { get; set; }

        /// <summary>
        /// Please provide the reason for export
        /// </summary>
        [JsonProperty("exportReasonType")]
        [JsonConverter(typeof(ExportReasonToStringJsonConverter))]
        public ExportReason? ExportReasonType { get; set; }

        /// <summary>
        /// Please enter two letter ISO manufacturer country code
        /// </summary>
        [JsonRequired]
        [JsonProperty("manufacturerCountry")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode? ManufacturerCountry { get; set; }

        /// <summary>
        /// Please enter the weight information for line item
        /// </summary>
        [JsonRequired]
        [JsonProperty("weight")]
        public LineItemWeightRequestModel? Weight { get; set; }

        /// <summary>
        /// Please provide if the Taxes is paid for the line item
        /// </summary>
        [JsonProperty("isTaxesPaid")]
        public bool IsTaxesPaid { get; set; }

        /// <summary>
        /// Please provide the additional information
        /// </summary>
        [JsonProperty("additionalInformation")]
        public IEnumerable<string>? AdditionalInformation { get; set; }

        /// <summary>
        /// Please provide the Customer References for the line item
        /// </summary>
        [JsonProperty("customerReferences")]
        public IEnumerable<CustomerReferenceRequestModel>? CustomerReferences { get; set; }

        /// <summary>
        /// Please provide the customs documents details
        /// </summary>
        [JsonProperty("customsDocuments")]
        public IEnumerable<CustomsDocumentRequestModel>? CustomsDocuments { get; set; }

        /// <summary>
        /// Please provide the line item customs document ID
        /// </summary>
        [JsonProperty("preCalculatedLineItemTotalValue")]
        public double PreCalcucatedLineItemTotalValue { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailLineItemRequestModel() : base()
        {

        }

        #endregion
    }
}