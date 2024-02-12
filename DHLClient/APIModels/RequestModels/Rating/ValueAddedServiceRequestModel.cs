using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Request used for creating or updating a value added service
    /// </summary>
    public class ValueAddedServiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter DHL Express value added global service code. For detailed list of all available service codes for your prospect shipment please invoke /products or /rates
        /// </summary>
        [JsonRequired]
        [JsonProperty("serviceCode")]
        public string? ServiceCode { get; set; }

        /// <summary>
        /// Please enter DHL Express value added local service code. For detailed list of all available service codes for your prospect shipment please invoke /products or /rates
        /// </summary>
        [JsonRequired]
        [JsonProperty("localServiceCode")]
        public string? LocalServiceCode { get; set; }

        /// <summary>
        /// Please enter monetary value of service (e.g. Insured Value)
        /// </summary>
        [JsonRequired]
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// Please enter currency code (e.g. Insured Value currency code)
        /// </summary>
        [JsonRequired]
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// The payment method (for future use)
        /// </summary>
        [JsonProperty("method")]
        [JsonConverter(typeof(PaymentMethodToStringJsonConverter))]
        public PaymentMethod Method { get; set; }

        /// <summary>
        /// The DangerousGoods section indicates if there is dangerous good content within the shipment.
        /// </summary>
        [JsonProperty("dangerousGoods")]
        public DangerousGoodRequestModel DangeroudGoods { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ValueAddedServiceRequestModel() : base()
        {

        }

        #endregion
    }
}