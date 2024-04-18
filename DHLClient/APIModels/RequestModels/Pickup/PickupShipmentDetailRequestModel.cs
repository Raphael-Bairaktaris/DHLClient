using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating pickup shipment details
    /// </summary>
    public class PickupShipmentDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide DHL Express Global product code of the shipment 
        /// </summary>
        [JsonRequired]
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// Please provide DHL Express Local product code of the shipment
        /// </summary>
        [JsonProperty("localProductCode")]
        public string? LocalProductCode { get; set; }

        /// <summary>
        /// The account
        /// </summary>
        [JsonProperty("accounts")]
        public IEnumerable<AccountRequestModel>? Accounts { get; set; }

        /// <summary>
        /// The value added services
        /// </summary>
        [JsonProperty("valueAddedServices")]
        public IEnumerable<ValueAddedServiceRequestModel>? ValueAddedServices { get; set; }

        /// <summary>
        /// For customs purposes please advise if your shipment is dutiable (true) or non dutiable (false)
        /// </summary>
        [JsonRequired]
        [JsonProperty("isCustomsDeclarable")]
        public bool IsCustomsDeclarable { get; set; }

        /// <summary>
        /// For customs purposes please advise on declared value of the shipment
        /// </summary>
        [JsonProperty("declaredValue")]
        public double DeclaredValue { get; set; }

        /// <summary>
        /// For customs purposes please advise on declared value currency code of the shipment
        /// </summary>
        [JsonProperty("declaredValueCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? DeclaredValueCurrency { get; set; }

        /// <summary>
        /// Please enter Unit of measurement
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        /// <summary>
        /// Please provide Shipment Identification number (AWB number)
        /// </summary>
        /// <example>123456790</example>
        [JsonProperty("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The package details
        /// </summary>
        [JsonRequired]
        [JsonProperty("packages")]
        public IEnumerable<RatingLandedCostPackageRequestModel>? Packages { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PickupShipmentDetailRequestModel() : base()
        {

        }

        #endregion
    }
}