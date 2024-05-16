using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating bank details
    /// </summary>
    public class ShipmentEntityBankDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Name field
        /// </summary>
        /// <example>Russian Bank Name</example>
        [JsonProperty("bank")]
        public string? BankName { get; set; }

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Value in RUR field
        /// </summary>
        /// <example>RUB</example>
        [JsonProperty("settlementLocalCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? SettlementLocalCurrency { get; set; }

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Value in RUR field
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
        public ShipmentEntityBankDetailRequestModel() : base()
        {

        }

        #endregion
    }
}