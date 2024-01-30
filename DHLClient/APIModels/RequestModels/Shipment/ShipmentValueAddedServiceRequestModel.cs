using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment value added service
    /// </summary>
    public class ShipmentValueAddedServiceRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter DHL Express value added service code. For detailed list of all available service codes for your prospect shipment please invoke GET /products or GET /rates
        /// </summary>
        [JsonRequired]
        [JsonProperty("serviceCode")]
        public string? ServiceCode { get; set; }

        /// <summary>
        /// Please enter monetary value of service
        /// </summary>
        /// <example>Insured Value</example>
        [JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Please enter currency code
        /// </summary>
        /// <example>Insured Value currency code</example>
        [JsonProperty("currency")]
        public CurrencyCode? Currency { get; set; }

        /// <summary>
        /// The payment method
        /// </summary>
        /// <example>Cash</example>
        [JsonProperty("method")]
        public PaymentMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dangerousGoods")]
        public DangerousGoodsRequestModel? DangerousGoods { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentValueAddedServiceRequestModel() : base()
        {

        }

        #endregion
    }
}