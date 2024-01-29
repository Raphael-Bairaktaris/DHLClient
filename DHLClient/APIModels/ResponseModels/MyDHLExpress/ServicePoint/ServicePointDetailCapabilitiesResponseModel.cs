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
        /// Array of numbers L W H
        /// </summary>
        [JsonProperty("pieceDimensionsLimit")]
        public PieceDimensionLimitResponseModel PieceDimensionsLimit { get; set; }

        /// <summary>
        /// Distance of SVP from searched location
        /// </summary>
        [JsonProperty("distanceValue")]
        public double DistanceValue { get; set; }

        /// <summary>
        /// Metric of distance
        /// </summary>
        [JsonProperty("distanceMetric")]
        public double DistanceMetric { get; set; }

        /// <summary>
        /// Information about language used for search
        /// </summary>
        [JsonProperty("language")]
        public ServicePointDetailLanguageResponseModel Language { get; set; }

        /// <summary>
        /// Information about shipment piece / size
        /// </summary>
        [JsonProperty("shipmentLimitations")]
        public ServicePointDetailShipmentLimitationResponseModel ShipmentLimitations { get; set; }

        /// <summary>
        /// Shipment Piece Limitations in this Service Point.
        /// </summary>
        [JsonProperty("shipmentLimitationsByPiece")]
        public ShipmentLimitaionByPieceResponseModel ShipmentLimitationsByPiece { get; set; }

        /// <summary>
        /// Charge code
        /// </summary>
        /// <example>XX</example>
        [JsonProperty("chargeCode")]
        public string ChargeCode { get; set; }

        /// <summary>
        /// Partner information (when SVP type is PRT)
        /// </summary>
        [JsonProperty("partner")]
        public ServicePointDetailPartnerResponseModel Partner { get; set; }

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