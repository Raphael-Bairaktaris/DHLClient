using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Request model used for creating or updating a rating
    /// </summary>
    public class RatingRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The customer details
        /// </summary>
        [JsonRequired]
        [JsonProperty("customerDetails")]
        public CustomerDetailRequestModel? CustomerDetails { get; set; }

        /// <summary>
        /// Please enter all the DHL Express accounts and types to be used for this shipment
        /// </summary>
        [JsonProperty("accounts")]
        public AccountRequestModel? Accounts { get; set; }

        /// <summary>
        /// Please enter DHL Express Global Product code
        /// </summary>
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please enter DHL Express Local Product code
        /// </summary>
        [JsonRequired]
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// Please use if you wish to filter the response by value added services
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public ValueAddedServiceRequestModel? ValueAddedServices { get; set; }

        /// <summary>
        /// Please use if you wish to filter the response by product(s) and/or value added services
        /// </summary>
        [JsonProperty("productsAndServices")]
        public ProductAndServiceRequestModel? ProductsAndServices { get; set; }

        /// <summary>
        /// payerCountryCode is to be provided if your profile has been enabled to view rates without 
        /// an account number (this will provide DHL Express published rates for the payer country)
        /// </summary>
        [JsonRequired]
        [JsonProperty("payerCountryCode")]
        public CountryCode PayerCountryCode { get; set; }

        /// <summary>
        /// Identifies the date and time the package is tendered. Both the date and time portions of the string are expected to be used. 
        /// The date should not be a past date or a date more than 10 days in the future. The time is the local time of the shipment based on the shipper's time zone. 
        /// The date component must be in the format: YYYY-MM-DD; the time component must be in the format: HH:MM:SS using a 24 hour clock. The date and time parts are 
        /// separated by the letter T (e.g. 2006-06-26T17:00:00 GMT+01:00).
        /// </summary>
        public DateTimeOffset? PlannedShippingDateAndTime { get; set; }

        /// <summary>
        /// Please enter Unit of measurement - metric,imperial
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        /// <summary>
        /// For customs purposes please advise if your shipment is dutiable (true) or non dutiable (false)
        /// </summary>
        [JsonRequired]
        [JsonProperty("isCustomsDeclarable")]
        public bool IsCustomsDeclarable { get; set; }

        /// <summary>
        /// Please provide monetary amount related to your shipment, for example shipment declared value
        /// </summary>
        [JsonProperty("monetaryAmount")]
        public MonetaryAmountRequestModel? MonetaryAmount { get; set; }

        /// <summary>
        /// Legacy field and replaced by newer field getAdditionalInformation. 
        /// Please set this to true to receive all value added services for each product available
        /// </summary>
        [JsonProperty("requestAllValueAddedServices")]
        public bool ShouldRequestAllValueAddedServices { get; set; }

        /// <summary>
        /// Estimated delivery date option for QDDF or QDDC.
        /// </summary>
        [JsonProperty("estimatedDeliveryDate")]
        public EstimatedDeliveryDateRequestModel? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Provides additional information in the response like all value added services, and rule groups
        /// </summary>
        [JsonProperty("getAdditionalInformation")]
        public GetAdditionalInformationRequestModel? GetAdditionalInformation { get; set; }

        /// <summary>
        /// Please set this to true to filter out all products which needs DHL Express special customer agreement
        /// </summary>
        [JsonProperty("returnStandardProductsOnly")]
        public bool ShouldReturnStandardProductsOnly { get; set; }

        /// <summary>
        /// Please set this to true in case you want to receive products which are not available on planned shipping date but next available day
        /// </summary>
        [JsonProperty("nextBusinessDay")]
        public bool ShouldDeliverNextBusinessDay { get; set; }

        /// <summary>
        /// Please select which type of products you are interested in
        /// </summary>
        [JsonProperty("productTypeCode")]
        public ProductType ProductTypeCode { get; set; }

        /// <summary>
        /// Here you can define properties per package
        /// </summary>
        [JsonRequired]
        [JsonProperty("packages")]
        public PackageRequestModel  Packages {get;set;}

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingRequestModel() : base()
        {

        }

        #endregion
    }
}
