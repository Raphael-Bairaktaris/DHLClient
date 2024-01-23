using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an indicative customs value
    /// </summary>
    public class IndicativeCustomsValueRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please provide the pre-calculated import customs duties value for the shipment
        /// </summary>
        /// <example>150.57</example>
        [JsonProperty("importCustomsDutyValue")]
        public decimal ImportCustomsDutyValue { get; set; }

        /// <summary>
        /// Please provide the pre-calculated import taxes (VAT/GST) value for the shipment
        /// </summary>
        /// <example>49.43</example>
        [JsonProperty("importTaxesValue")]
        public decimal ImportTaxesValue { get; set; }

        /// <summary>
        /// Please provide pre-calculated total of all line items plus additional charges plus indicativeCustomsValues
        /// </summary>
        /// <example>350.57</example>
        [JsonProperty("totalWithImportDutiesAndTaxes")]
        public decimal TotalWithImportDutiesAndTaxes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IndicativeCustomsValueRequestModel() : base()
        {

        }

        #endregion
    }
}