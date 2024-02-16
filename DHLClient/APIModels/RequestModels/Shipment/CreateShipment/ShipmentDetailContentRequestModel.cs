using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment content
    /// </summary>
    public class ShipmentDetailContentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Here you can define properties per package
        /// </summary>
        [JsonRequired]
        [JsonProperty("packages")]
        public IEnumerable<ShipmentDetailContentPackageRequestModel>? Packages { get; set; }

        /// <summary>
        /// For customs purposes please advise if your shipment is dutiable (true) or non dutiable (false).
        /// Note:If the shipment is dutiable, exportDeclaration element must be provided.
        /// </summary>
        [JsonRequired]
        [JsonProperty("isCustomsDeclarable")]
        public bool? IsCustomsDeclarable { get; set; }

        /// <summary>
        /// For customs purposes please advise on declared value of the shipment
        /// </summary>
        [JsonProperty("declaredValue")]
        public double? DeclaredValue { get; set; }

        /// <summary>
        /// For customs purposes please advise on declared value currency code of the shipment
        /// </summary>
        [JsonProperty("declaredValueCurrency")]
        [JsonConverter(typeof(CurrencyCodeToStringJsonConverter))]
        public CurrencyCode? DeclaredValueCurrency { get; set; }

        /// <summary>
        /// Here you can find all details related to export declaration
        /// </summary>
        [JsonProperty("exportDeclaration")]
        public IEnumerable<ShipmentDetailExportDeclarationRequestModel>? ExportDeclaration { get; set; }

        /// <summary>
        /// Please enter description of your shipment
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is used for the US AES4, FTR and ITN numbers to be printed on the Transport Label
        /// </summary>
        [JsonProperty("USFilingTypeValue")]
        public string? USFillingTypeValue { get; set; }

        /// <summary>
        /// The Incoterms rules are a globally-recognized set of standards, used worldwide in international and domestic 
        /// contracts for the delivery of goods, illustrating responsibilities between buyer and seller for costs and risk, as well as cargo insurance.
        /// </summary>
        [JsonProperty("incoterm")]
        [JsonConverter(typeof(IncotermRuleToStringJsonConverter))]
        public IncotermRule Incoterm { get; set; }

        /// <summary>
        /// Please enter Unit of measurement
        /// </summary>
        [JsonRequired]
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit UnitOfMeasurement { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailContentRequestModel() : base()
        {

        }

        #endregion
    }
}