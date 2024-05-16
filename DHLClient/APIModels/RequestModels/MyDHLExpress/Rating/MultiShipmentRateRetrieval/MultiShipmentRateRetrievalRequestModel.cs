using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The Rate request will return DHL's product capabilities and prices (where applicable) based on the input data. 
    /// Using the shipper and receiver address as well as the dimension and weights of the pieces belonging to a shipment, 
    /// this operation returns the available products including the shipping price (where applicable)
    /// </summary>
    public class MultiShipmentRateRetrievalRequestModel : BaseRatingRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please use if you wish to filter the response by value added services
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public IEnumerable<ValueAddedServiceRequestModel>? ValueAddedServices { get; set; }

        /// <summary>
        /// Please use if you wish to filter the response by product(s) and/or value added services
        /// </summary>
        [JsonProperty("productsAndServices")]
        public IEnumerable<ProductAndServiceRequestModel>? ProductsAndServices { get; set; }

        /// <summary>
        /// payerCountryCode is to be provided if your profile has been enabled to view rates without 
        /// an account number (this will provide DHL Express published rates for the payer country)
        /// </summary>
        /// <example>CZ</example>
        [JsonProperty("payerCountryCode")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode? PayerCountryCode { get; set; }

        /// <summary>
        /// Identifies the date and time the package is tendered. Both the date and time portions of the string are expected to be used. 
        /// The date should not be a past date or a date more than 10 days in the future. The time is the local time of the shipment based on the shipper's time zone. 
        /// The date component must be in the format: YYYY-MM-DD; the time component must be in the format: HH:MM:SS using a 24 hour clock. The date and time parts are 
        /// separated by the letter T (e.g. 2006-06-26T17:00:00 GMT+01:00).
        /// </summary>
        /// <example>2020-03-24T13:00:00GMT+00:00</example>
        [JsonRequired]
        [JsonProperty("plannedShippingDateAndTime")]
        [JsonConverter(typeof(DateTimeOffsetWithGMTPrefixToStringJsonConverter), false)]
        public DateTimeOffset? PlannedShippingDateAndTime { get; set; }

        /// <summary>
        /// Please enter Unit of measurement - metric,imperial
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit? MeasurementUnit { get; set; }

        /// <summary>
        /// For customs purposes please advise if your shipment is dutiable (true) or non dutiable (false)
        /// </summary>
        [JsonRequired]
        [JsonProperty("isCustomsDeclarable")]
        public bool? IsCustomsDeclarable { get; set; }

        /// <summary>
        /// Please provide monetary amount related to your shipment, for example shipment declared value
        /// </summary>
        [JsonProperty("monetaryAmount")]
        public IEnumerable<MonetaryAmountRequestModel>? MonetaryAmount { get; set; }

        /// <summary>
        /// Legacy field and replaced by newer field getAdditionalInformation. 
        /// Please set this to true to receive all value added services for each product available
        /// </summary>
        [JsonProperty("requestAllValueAddedServices")]
        public bool? ShouldRequestAllValueAddedServices { get; set; }

        /// <summary>
        /// Estimated delivery date option for QDDF or QDDC.
        /// </summary>
        [JsonProperty("estimatedDeliveryDate")]
        public ShipmentDetailEstimatedDeliveryDateRequestModel? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Provides additional information in the response like all value added services, and rule groups
        /// </summary>
        [JsonProperty("getAdditionalInformation")]
        public IEnumerable<ShipmentDetailGetAdditionalInformationRequestModel>? GetAdditionalInformation { get; set; }

        /// <summary>
        /// Please set this to true to filter out all products which needs DHL Express special customer agreement
        /// </summary>
        [JsonProperty("returnStandardProductsOnly")]
        public bool? ShouldReturnStandardProductsOnly { get; set; }

        /// <summary>
        /// Please set this to true in case you want to receive products which are not available on planned shipping date but next available day
        /// </summary>
        [JsonProperty("nextBusinessDay")]
        public bool? ShouldDeliverNextBusinessDay { get; set; }

        /// <summary>
        /// Please select which type of products you are interested in
        /// </summary>
        [JsonProperty("productTypeCode")]
        [JsonConverter(typeof(ProductTypeToStringJsonConverter))]
        public ProductType? ProductTypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MultiShipmentRateRetrievalRequestModel() : base()
        {

        }

        #endregion
    }
}
