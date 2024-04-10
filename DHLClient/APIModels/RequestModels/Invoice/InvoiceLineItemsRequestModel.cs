using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating line items
    /// </summary>
    public class InvoiceLineItemsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide line item number
        /// </summary>
        /// <example>1</example>
        [JsonRequired]
        [JsonProperty("number")]
        public double Number { get; set; }

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
        /// <example>150</example>
        public decimal? Price { get; set; }

        /// <summary>
        /// Please enter information about quantity for this line item
        /// </summary>
        [JsonRequired]
        [JsonProperty("quantity")]
        public ShipmentDetailLineItemQuantityRequestModel? Quantity { get; set; }

        /// <summary>
        /// Please provide Commodity codes for the shipment at item line level
        /// </summary>
        [JsonProperty("commodityCodes")]
        public IEnumerable<LineItemCommodityCodeRequestModel>? CommodityCodes { get; set; }

        /// <summary>
        /// Please provide the reason for export
        /// </summary>
        /// <example>temporary</example>
        [JsonRequired]
        [JsonProperty("exportReasonType")]
        [JsonConverter(typeof(ExportReasonToStringJsonConverter))]
        public ExportReason? ExportReasonType { get; set; }

        /// <summary>
        /// Please enter two letter ISO manufacturer country code
        /// </summary>
        /// <example>CZ</example>
        [JsonRequired]
        [JsonProperty("manufacturerCountry")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode ManufacturerCountry { get; set; }

        /// <summary>
        /// Please enter the weight information for line item. 
        /// Either a netValue or grossValue must be provided for the line item.
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
        /// Please provide the Customer References for the line item
        /// </summary>
        [JsonProperty("customerReferences")]
        public IEnumerable<LineItemCustomerReferenceRequestModel>? CustomerReferences { get; set; }

        /// <summary>
        /// Please provide the line item customs document type code.
        /// </summary>
        [JsonProperty("customsDocuments")]
        public IEnumerable<CustomsDocumentRequestModel>? CustomsDocuments { get; set; }

        /// <summary>
        /// Please provide monetary value of the line item x quantity
        /// </summary>
        [JsonProperty("preCalculatedLineItemTotalValue")]
        public decimal PreCalculatedLineItemTotalValue { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceLineItemsRequestModel() : base()
        {

        }

        #endregion
    }
}