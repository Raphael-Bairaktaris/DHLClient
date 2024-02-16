using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a bank detail
    /// </summary>
    public class ShipmentCustomerBankDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Name field
        /// </summary>
        /// <example>Russian Bank Name</example>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Number in RUR field
        /// </summary>
        /// <example>RUB</example>
        [JsonProperty("settlementLocalCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? SettlementLocalCurrency { get; set; }

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Number in RUR field
        /// </summary>
        /// <example>USD</example>
        [JsonProperty("settlementForeignCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? SettlementForeignCurrency { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentCustomerBankDetailRequestModel() : base()
        {

        }

        #endregion
    }
}