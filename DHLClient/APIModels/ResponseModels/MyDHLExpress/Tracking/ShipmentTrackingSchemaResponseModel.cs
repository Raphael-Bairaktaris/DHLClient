using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment tracking schema
    /// </summary>
    public class ShipmentTrackingSchemaResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        /// <summary>
        /// The member of the <see cref="ProductCode"/> property
        /// </summary>
        private string? mProductCode;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// the member of the <see cref="ShipperDetails"/> property
        /// </summary>
        private ShipmentShipperDetailResponseModel? mShipperDetails;

        /// <summary>
        /// The member of the <see cref="ReceiverDetails"/> property
        /// </summary>
        private ShipmentReceiverDetailResponseModel? mReceiverDetails;

        /// <summary>
        /// the member of the <see cref="ShipperReferences"/> property
        /// </summary>
        private IEnumerable<ShipmentShipperReferenceResponseModel>? mShipperReferences;

        /// <summary>
        /// The member of the <see cref="Events"/> property
        /// </summary>
        private IEnumerable<ShipmentOccurrenceResponseModel>? mEvents;

        /// <summary>
        /// The member of the <see cref="Pieces"/> property
        /// </summary>
        private IEnumerable<ShipmentPieceResponseModel>? mPieces;

        /// <summary>
        /// The member of the <see cref="ChildrenShipmentIdentificationNumbers"/> property
        /// </summary>
        private IEnumerable<double>? mChildrenShipmentIdentificationNumbers;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipment tracking number
        /// </summary>
        [JsonProperty("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        /// <examnple>Success</examnple>
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        /// <summary>
        /// The shipment timestamp
        /// </summary>
        /// <example>2020-05-14T18:00:31</example>
        [JsonProperty("shipmentTimestamp")]
        public DateTimeOffset ShipmentTimestamp { get; set; }

        /// <summary>
        /// The DHL product code
        /// value -> min: 1, max: 1
        /// </summary>
        /// <example>N</example>
        [JsonProperty("productCode")]
        public string ProductCode
        {
            get => mProductCode ?? string.Empty;
            set => mProductCode = value;
        }

        /// <summary>
        /// The shipment description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The shipper details
        /// </summary>
        [JsonProperty("shipperDetails")]
        public ShipmentShipperDetailResponseModel ShipperDetails
        {
            get => mShipperDetails ??= new ShipmentShipperDetailResponseModel();
            set => mShipperDetails = value;
        }

        /// <summary>
        /// The receiver's details
        /// </summary>
        [JsonProperty("receiverDetails")]
        public ShipmentReceiverDetailResponseModel ReceiverDetails
        {
            get => mReceiverDetails ??= new ShipmentReceiverDetailResponseModel();
            set => mReceiverDetails = value;
        }

        /// <summary>
        /// The shipment's total weight
        /// </summary>
        [JsonProperty("totalWeight")]
        public double TotalWeight { get; set; }

        /// <summary>
        /// The unit of measurement
        /// </summary>
        /// <example>metric</example>
        [JsonProperty("unitOfMeasurement")]
        [JsonConverter(typeof(MeasurmentUnitToStringJsonConverter))]
        public MeasurmentUnit UnitOfMeasurement { get; set; }

        /// <summary>
        /// The shipment's shipper references
        /// </summary>
        [JsonProperty("shipperReferences")]
        public IEnumerable<ShipmentShipperReferenceResponseModel> ShipperReferences
        {
            get => mShipperReferences ??= Enumerable.Empty<ShipmentShipperReferenceResponseModel>();
            set => mShipperReferences = value;
        }

        /// <summary>
        /// The shipment's events
        /// </summary>
        [JsonProperty("events")]
        public IEnumerable<ShipmentOccurrenceResponseModel> Events
        {
            get => mEvents ??= Enumerable.Empty<ShipmentOccurrenceResponseModel>();
            set => mEvents = value;
        }

        /// <summary>
        /// The shipment's number of pieces 
        /// </summary>
        /// <example>1</example>
        [JsonProperty("numberOfPieces")]
        public double NumberOfPieces { get; set; }

        /// <summary>
        /// The shipment's piece details
        /// </summary>
        [JsonProperty("pieces")]
        public IEnumerable<ShipmentPieceResponseModel> Pieces
        {
            get => mPieces ??= Enumerable.Empty<ShipmentPieceResponseModel>();
            set => mPieces = value;
        }

        /// <summary>
        /// The shipment's estimated delivery date
        /// </summary>
        /// <example>2020-06-12</example>
        [JsonProperty("estimatedDeliveryDate")]
        public DateOnly EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The children shipment identification numbers
        /// </summary>
        [JsonProperty("childrenShipmentIdentificationNumbers")]
        public IEnumerable<double> ChildrenShipmentIdentificationNumbers
        {
            get => mChildrenShipmentIdentificationNumbers ?? Enumerable.Empty<double>();
            set => mChildrenShipmentIdentificationNumbers = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingSchemaResponseModel() : base()
        {

        }

        #endregion
    }
}
