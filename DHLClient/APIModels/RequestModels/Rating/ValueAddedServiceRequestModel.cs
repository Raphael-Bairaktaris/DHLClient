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
        /// Please enter DHL Express value added global service code. 
        /// For detailed list of all available service codes for your prospect shipment please invoke /products or /rates
        /// </summary>
        /// <example>II</example>
        [JsonRequired]
        [JsonProperty("serviceCode")]
        public string? ServiceCode { get; set; }

        /// <summary>
        /// Please enter DHL Express value added local service code. 
        /// For detailed list of all available service codes for your prospect shipment please invoke /products or /rates
        /// </summary>
        /// <example>II</example>
        [JsonProperty("localServiceCode")]
        public string? LocalServiceCode { get; set; }

        /// <summary>
        /// Please enter monetary value of service (e.g. Insured Value)
        /// </summary>
        [JsonProperty("value")]
        public decimal? Value { get; set; }

        /// <summary>
        /// Please enter currency code (e.g. Insured Value currency code)
        /// </summary>
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? Currency { get; set; }

        /// <summary>
        /// The payment method (for future use)
        /// </summary>
        [JsonProperty("method")]
        [JsonConverter(typeof(PaymentMethodToStringJsonConverter))]
        public PaymentMethod? Method { get; set; }

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