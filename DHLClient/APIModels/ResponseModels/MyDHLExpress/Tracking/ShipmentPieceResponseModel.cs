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
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

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

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipment piece number 
        /// </summary>
        /// <example>1</example>
        [JsonProperty("number")]
        public double Number { get; set; }

        /// <summary>
        /// The type code
        /// </summary>
        [JsonProperty("typeCode")]
        public string TypeCode { get; set; }

        /// <summary>
        /// The shipment tracking number
        /// </summary>
        [JsonProperty("shipmentTrackingNumber")]
        public double ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The tracking number
        /// </summary>
        [JsonProperty("trackingNumber")]
        public double TrackingNumber { get; set; }

        /// <summary>
        /// the piece description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The weight of the package
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// The dimensional weight of the package
        /// </summary>
        [JsonProperty("dimensionalWeight")]
        public double DimensionalWeight { get; set; }

        /// <summary>
        /// The actual weight of the package
        /// </summary>
        [JsonProperty("actualWeight")]
        public double ActualWeight { get; set; }

        /// <summary>
        /// The shipment's dimensions
        /// </summary>
        [JsonProperty("dimensions")]
        public ShipmentDetailDimensionResponseModel Dimensions
        {
            get => mDimensions ??= new ShipmentDetailDimensionResponseModel();
            set => mDimensions = value;
        }

        /// <summary>
        /// The shipment's actual dimensions 
        /// </summary>
        [JsonProperty("actualDimensions")]
        public ShipmentActualDimensionResponseModel ActualDimensions
        {
            get => mActualDimensions ??= new ShipmentActualDimensionResponseModel();
            set => mActualDimensions = value;
        }

        /// <summary>
        /// The shipment's references
        /// </summary>
        [JsonProperty("shipmentReferences")]
        public ShipmentShipperReferenceResponseModel ShipmentReferences
        {
            get => mShipmentReferences ??= new ShipmentShipperReferenceResponseModel();
            set => mShipmentReferences = value;
        }

        /// <summary>
        /// The shipment's events
        /// </summary>
        [JsonProperty("events")]
        public ShipmentOccurrenceResponseModel Events
        {
            get => mEvents ??= new ShipmentOccurrenceResponseModel();
            set => mEvents = value;
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
    }
}