using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating an uploaded invoice content
    /// </summary>
    public class UploadInvoiceContentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Here you can find all details related to export declaration
        /// </summary>
        [JsonRequired]
        [JsonProperty("exportDeclaration")]
        public IEnumerable<UploadInvoiceExportDeclarationRequestModel>? ExportDeclaration { get; set; }

        /// <summary>
        /// For customs purposes please advise on currency code of the indicated amount in invoice.
        /// </summary>
        [JsonRequired]
        [JsonProperty("currency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? Currency { get; set; }

        /// <summary>
        /// Please enter Unit of measurement - metric,imperial
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit? UnitOfMeasurement { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadInvoiceContentRequestModel() : base()
        {

        }

        #endregion
    }
}