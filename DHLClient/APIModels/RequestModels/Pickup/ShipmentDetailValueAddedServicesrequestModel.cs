using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// requests used for creating or updating shipment detail value added services
    /// </summary>
    public class ShipmentDetailValueAddedServicesRequestModel
    {
        #region Public Properties

        /// <summary>
        /// For customs purposes please advise if your shipment is dutiable (true) or non dutiable (false)
        /// </summary>
        [JsonRequired]
        [JsonProperty("IsCustomsDeclarable")]
        public bool? IsCustomsDeclarable { get; set; }

        /// <summary>
        /// For customs purposes please advise on declared value of the shipment
        /// </summary>
        [JsonProperty("declaredValue")]
        public double? DeclaredValue { get; set; }

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
        public double? ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The package details
        /// </summary>
        [JsonRequired]
        [JsonProperty("packages")]
        public PackageRequestModel? Packages { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailValueAddedServicesRequestModel() : base()
        {

        }

        #endregion
    }
}