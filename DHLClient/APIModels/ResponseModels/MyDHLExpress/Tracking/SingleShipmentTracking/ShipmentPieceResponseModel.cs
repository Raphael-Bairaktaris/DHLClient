using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment piece response
    /// </summary>
    public class ShipmentPieceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="Dimensions"/> property
        /// </summary>
        private ShipmentDetailDimensionResponseModel? mDimensions;

        /// <summary>
        /// The member of the <see cref="ActualDimensions"/> property
        /// </summary>
        private ShipmentActualDimensionResponseModel? mActualDimensions;

        /// <summary>
        /// The member of the <see cref="ShipmentReferences"/> property
        /// </summary>
        private ShipmentShipperReferenceResponseModel? mShipmentReferences;

        /// <summary>
        /// The member of the <see cref="Events"/> property
        /// </summary>
        private ShipmentOccurrenceResponseModel? mEvents;

        /// <summary>
        /// The member of the <see cref="Pieces"/> property
        /// </summary>
        private IEnumerable<ShipmentPieceResponseModel>? mPieces;

        /// <summary>
        /// The member of the <see cref="ChildrenShipmentIdentificationNumbers"/> property
        /// </summary>
        private IEnumerable<string>? mChildrenShipmentIdentificationNumbers;

        /// <summary>
        /// The member of the <see cref="ControlledAccessDataCodes"/> property
        /// </summary>
        private IEnumerable<string>? mControlledAccessDataCodes;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipment piece number 
        /// </summary>
        /// <example>1</example>
        [JsonProperty("number")]
        public double? Number { get; set; }

        /// <summary>
        /// The type code
        /// </summary>
        [JsonProperty("typeCode")]
        public string? TypeCode { get; set; }

        /// <summary>
        /// The shipment tracking number
        /// </summary>
        [JsonProperty("shipmentTrackingNumber")]
        public long? ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The tracking number
        /// </summary>
        [JsonProperty("trackingNumber")]
        public double? TrackingNumber { get; set; }

        /// <summary>
        /// the piece description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The weight of the package
        /// </summary>
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// The dimensional weight of the package
        /// </summary>
        [JsonProperty("dimensionalWeight")]
        public double? DimensionalWeight { get; set; }

        /// <summary>
        /// The actual weight of the package
        /// </summary>
        [JsonProperty("actualWeight")]
        public double? ActualWeight { get; set; }

        /// <summary>
        /// The shipment's dimensions
        /// </summary>
        [JsonProperty("dimensions")]
        public ShipmentDetailDimensionResponseModel? Dimensions
        {
            get => mDimensions ??= new ShipmentDetailDimensionResponseModel();
            set => mDimensions = value;
        }

        /// <summary>
        /// The shipment's actual dimensions 
        /// </summary>
        [JsonProperty("actualDimensions")]
        public ShipmentActualDimensionResponseModel? ActualDimensions
        {
            get => mActualDimensions ??= new ShipmentActualDimensionResponseModel();
            set => mActualDimensions = value;
        }

        /// <summary>
        /// The measurement units
        /// </summary>
        [JsonProperty("unitOfMeasurements")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit? UnitOfMeasurements { get; set; }

        /// <summary>
        /// The shipment's references
        /// </summary>
        [JsonProperty("shipmentReferences")]
        public ShipmentShipperReferenceResponseModel? ShipmentReferences
        {
            get => mShipmentReferences ??= new ShipmentShipperReferenceResponseModel();
            set => mShipmentReferences = value;
        }

        /// <summary>
        /// The shipment's events
        /// </summary>
        [JsonProperty("events")]
        public ShipmentOccurrenceResponseModel? Events
        {
            get => mEvents ??= new ShipmentOccurrenceResponseModel();
            set => mEvents = value;
        }

        /// <summary>
        /// The number of pieces
        /// </summary>
        [JsonProperty("numberOfPieces")]
        public int NumberOfPieces { get; set; }

        /// <summary>
        /// Here you can find the piece details
        /// </summary>
        [JsonProperty("pieces")]
        public IEnumerable<ShipmentPieceResponseModel> Pieces
        {
            get => mPieces ?? Enumerable.Empty<ShipmentPieceResponseModel>();
            set => mPieces = value;
        }

        /// <summary>
        /// The estimated delivery date
        /// </summary>
        /// <example>2020-06-12</example>
        [JsonProperty("estimatedDeliveryDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The children shipment identification numbers
        /// </summary>
        [JsonProperty("childrenShipmentIdentificationNumbers")]
        public IEnumerable<string> ChildrenShipmentIdentificationNumbers
        {
            get => mChildrenShipmentIdentificationNumbers ?? Enumerable.Empty<string>();
            set => mChildrenShipmentIdentificationNumbers = value;
        }

        /// <summary>
        /// Controlled access data codes such as 'SHPR_CTY' for shipper's city, 'CNSGN_CTY' for consignee's city, 'SVP_URL' for service point URL, 
        /// 'SVP_FAC' for service point facility code and 'SIGN_NM' for signatory name.
        /// </summary>
        [JsonProperty("controlledAccessDataCodes")]
        public IEnumerable<string> ControlledAccessDataCodes
        {
            get => mControlledAccessDataCodes ?? Enumerable.Empty<string>();
            set => mControlledAccessDataCodes = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentPieceResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Number: {Number}, Shipment Tracking Number: {ShipmentTrackingNumber}, Number Of Pieces: {NumberOfPieces}";

        #endregion
    }
}