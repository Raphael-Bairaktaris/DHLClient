using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service point detail capabilities response
    /// </summary>
    public class ServicePointDetailCapabilitiesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ParkingTitle"/> property
        /// </summary>
        private string? mParkingTitle;

        /// <summary>
        /// The member of the <see cref="DisabledAccessTitle"/> property
        /// </summary>
        private string? mDisabledAccessTitle;

        /// <summary>
        /// The member of the <see cref="PieceDimensionsLimit"/> property
        /// </summary>
        private PieceDimensionLimitResponseModel? mPieceDimensionsLimit;

        /// <summary>
        /// The member of the <see cref="PPCList"/> property
        /// </summary>
        private IEnumerable<string>? mPPCList;

        /// <summary>
        /// The member of the <see cref="CapabilityCodes"/> property
        /// </summary>
        private string? mCapabilityCodes;

        #endregion

        #region Public Properties

        /// <summary>
        /// Indicates whether parking facility is available in the service point or not
        /// </summary>
        [JsonProperty("availableParking")]
        public bool HasAvailableParking { get; set; }

        /// <summary>
        /// Indicates whether disabled access is available in the service point or not
        /// </summary>
        [JsonProperty("disabledAccess")]
        public bool HasDisabledAccess { get; set; }

        /// <summary>
        /// Indicates whether Shipment Drop Off is available in the service point or not
        /// </summary>
        [JsonProperty("shipmentDropOff")]
        public bool HasShipmentDropOff { get; set; }

        /// <summary>
        /// Indicates whether Shipment Collection is available in the service point or not
        /// </summary>
        [JsonProperty("shipmentCollection")]
        public bool HasShipmentCollection { get; set; }

        /// <summary>
        /// Indicates whether International Shipping is available in the service point or not
        /// </summary>
        [JsonProperty("internationalShipping")]
        public bool HasInternationalShipping { get; set; }

        /// <summary>
        /// Indicates whether Domestic Shipping is available in the service point or not
        /// </summary>
        [JsonProperty("domesticShipping")]
        public bool HasDomesticShipping { get; set; }

        /// <summary>
        /// Indicates whether Account Shipping is available in the service point or not
        /// </summary>
        [JsonProperty("accountShipping")]
        public bool HasAccountShipping { get; set; }

        /// <summary>
        /// Indicates whether Label Printing is available in the service point or not
        /// </summary>
        [JsonProperty("labelPrinting")]
        public bool HasLabelPrinting { get; set; }

        /// <summary>
        /// Indicates whether Insurance facility is available in the service point or not
        /// </summary>
        [JsonProperty("insurance")]
        public bool HasInsurance { get; set; }

        /// <summary>
        /// Indicates whether Import Charges is applicable in the service point or not
        /// </summary>
        [JsonProperty("importCharges")]
        public bool HasImportCharges { get; set; }

        /// <summary>
        /// Indicates whether Packaging facility is available in the service point or not
        /// </summary>
        [JsonProperty("packaging")]
        public bool HasPackaging { get; set; }

        /// <summary>
        /// Indicates whether Receiver Paying option is available in the service point or not
        /// </summary>
        [JsonProperty("receiverPaid")]
        public bool HasReceiverPaidOption { get; set; }

        /// <summary>
        /// Indicates whether VISA program is applicable in the service point or not
        /// </summary>
        [JsonProperty("visaProgram")]
        public bool HasVisaProgram { get; set; }

        /// <summary>
        /// Indicates whether pay by cash option is available in the service point or not
        /// </summary>
        [JsonProperty("payWithCash")]
        public bool PayWithCashOptionAvailable { get; set; }

        /// <summary>
        /// Indicates whether pay with credit card option is available in the service point or not
        /// </summary>
        [JsonProperty("payWithCreditCard")]
        public bool PayWithCreditCardOptionAvailable { get; set; }

        /// <summary>
        /// Indicates whether pay with cheque option is available in the service point or not
        /// </summary>
        [JsonProperty("payWithCheque")]
        public bool PayWithChequeOptionAvailable { get; set; }

        /// <summary>
        /// Indicates whether pay with mobile option is available in the service point or not
        /// </summary>
        [JsonProperty("payWithMobile")]
        public bool PayWithMobileOptionAvailable { get; set; }

        /// <summary>
        /// Indicates whether pay with paypal option is available in the service point or not
        /// </summary>
        [JsonProperty("payWithPayPal")]
        public bool PayWithPayPalOptionAvailable { get; set; }

        /// <summary>
        /// Title for the parking icon
        /// </summary>
        [JsonProperty("parkingTitle")]
        public string ParkingTitle
        {
            get => mParkingTitle ?? string.Empty;
            set => mParkingTitle = value;
        }

        /// <summary>
        /// Title for the disable wheel chair icon
        /// </summary>
        [JsonProperty("disabledAccessTitle")]
        public string DisabledAccessTitle
        {
            get => mDisabledAccessTitle ?? string.Empty;
            set => mDisabledAccessTitle = value;
        }

        /// <summary>
        /// Piece Weight Limit
        /// </summary>
        [JsonProperty("pieceWeightLimit")]
        public double PieceWeightLimit { get; set; }

        /// <summary>
        /// Enumeration (KG or LB)
        /// </summary>
        [JsonProperty("pieceWeightLimitUnit")]
        public WeightUnit PieceWeightLimitUnit { get; set; }

        /// <summary>
        /// Array of numbers Length Weight Height
        /// </summary>
        [JsonProperty("pieceDimensionsLimit")]
        public PieceDimensionLimitResponseModel PieceDimensionsLimit
        {
            get => mPieceDimensionsLimit ??= new PieceDimensionLimitResponseModel();
            set => mPieceDimensionsLimit = value;
        }

        /// <summary>
        /// Enumeration (CM or IN)
        /// </summary>
        [JsonProperty("pieceDimensionsLimitUnit")]
        [JsonConverter(typeof(DimensionUnitToStringJsonConverter))]
        public DimensionUnit PieceDimensionsLimitUnit { get; set; }

        /// <summary>
        /// The piece count limit
        /// </summary>
        [JsonProperty("pieceCountLimit")]
        public double PieceCountLimit { get; set; }

        /// <summary>
        /// Account prepaid shippers
        /// </summary>
        [JsonProperty("accountPrepaidShippers")]
        public bool HasAccountPrepaidShippers { get; set; }

        /// <summary>
        /// Prepaid shippers
        /// </summary>
        [JsonProperty("prepaidShippers")]
        public bool HasPrepaidShippers { get; set; }

        /// <summary>
        /// Pre-printed return label
        /// </summary>
        [JsonProperty("prePrintReturnLabel")]
        public bool HasPrePrinReturnLabel { get; set; }

        /// <summary>
        /// Indicates whether this particular service point can handle label free shipments or not
        /// </summary>
        [JsonProperty("labelFree")]
        public bool IsLabelFree { get; set; }

        /// <summary>
        /// The PPC list.
        /// </summary>
        [JsonProperty("ppcList")]
        public IEnumerable<string> PPCList
        {
            get => mPPCList ?? Enumerable.Empty<string>();
            set => mPPCList = value;
        }

        /// <summary>
        /// PPC codes available for this service point
        /// </summary>
        [JsonProperty("capabilityCodes")]
        public string CapabilityCodes
        {
            get => mCapabilityCodes ?? string.Empty;
            set => mCapabilityCodes = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointDetailCapabilitiesResponseModel() : base()
        {

        }

        #endregion
    }
}