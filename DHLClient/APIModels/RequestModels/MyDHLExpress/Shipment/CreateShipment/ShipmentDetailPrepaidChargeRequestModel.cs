using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating prepaid charge
    /// </summary>
    public class ShipmentDetailPrepaidChargeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please enter type of prepaid charge. At this moment only freight is supported
        /// </summary>
        [JsonRequired]
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(PrepaidChargeToStringJsonConverter))]
        public PrepaidCharge TypeCode { get; set; }

        /// <summary>
        /// Please enter currency for the value you have entered into value field
        /// </summary>
        [JsonRequired]
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Please enter nominal value related to the charge
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// Please enter method you have used to pay the charges. At this moment only cash is supported
        /// </summary>
        [JsonRequired]
        [JsonProperty("method")]
        [JsonConverter(typeof(PaymentMethodToStringJsonConverter))]
        public PaymentMethod Method { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailPrepaidChargeRequestModel() : base()
        {

        }

        #endregion
    }
}