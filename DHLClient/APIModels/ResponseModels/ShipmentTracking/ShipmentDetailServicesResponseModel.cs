using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment detail services response
    /// </summary>
    public class ShipmentDetailServicesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceCriteria"/> property
        /// </summary>
        private string? mServiceCriteria;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipping option
        /// </summary>
        [JsonProperty("serviceType")]
        [JsonConverter(typeof(ShippingOptionToStringJsonConverter))]
        public ShippingOption ServiceType { get; set; }

        /// <summary>
        /// The service criteria
        /// </summary>
        [JsonProperty("serviceCriteria")]
        public string ServiceCriteria
        {
            get => mServiceCriteria ?? string.Empty;
            set => mServiceCriteria = value;
        }

        /// <summary>
        /// Indicates whether the shipment has value added services
        /// </summary>
        [JsonProperty("serviceFlag")]
        public bool HasServiceFlag { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailServicesResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        public override string ToString() => $"Service Type: {ServiceType}";

        #endregion
    }
}