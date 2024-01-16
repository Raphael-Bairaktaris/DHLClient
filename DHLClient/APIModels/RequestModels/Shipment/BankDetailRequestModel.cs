using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating bank details
    /// </summary>
    public class BankDetailRequestModel
    {
        #region Public Properties

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Name field
        /// </summary>
        /// <example>Russian Bank Name</example>
        [JsonProperty("bank")]
        public string? BankName { get; set; }

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Number in RUR field
        /// </summary>
        /// <example>RUB</example>
        [JsonProperty("settlementLocalCurrency")]
        public CurrencyCode? SettlementLocalCurrency { get; set; }

        /// <summary>
        /// To be mapped in commercial Invoice - Russia Bank Settlement Account Number in RUR field
        /// </summary>
        /// <example>USD</example>
        [JsonProperty("settlementForeignCurrency")]
        public CurrencyCode? SettlementForeignCurrency { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BankDetailRequestModel() : base()
        {

        }

        #endregion
    }
}