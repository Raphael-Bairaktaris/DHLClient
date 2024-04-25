using DHLClient.DataModels.Enums;

namespace DHLClient
{
    /// <summary>
    /// Arguments used tracking a single or multiple shipments
    /// </summary>
    public class TrackMultipleShipmentAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express shipment identification number
        /// </summary>
        /// <example>9356579890</example>
        [ArgumentName("shipmentTrackingNumber")]
        public IEnumerable<long>? ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// DHL Express shipment piece tracking number
        /// </summary>
        [ArgumentName("pieceTrackingNumber")]
        public IEnumerable<string>? PieceTrackingNumber { get; set; }

        /// <summary>
        /// Shipment reference which was provided during the shipment label creation
        /// </summary>
        /// <example>CustomerReference1</example>
        [ArgumentName("shipmentReference")]
        public string? ShipmentReference { get; set; }

        /// <summary>
        /// Shipment reference type which was provided during the shipment label creation
        /// </summary>
        /// <example>CU</example>
        [ArgumentName("shipmentReferenceType")]
        public string? ShipmentReferenceType { get; set; }

        /// <summary>
        /// Shipper DHL Express Account number under which the shipment label was created
        /// </summary>
        /// <example>123456789</example>
        [ArgumentName("shipperAccountNumber")]
        public int? ShipperAccountNumber { get; set; }

        /// <summary>
        /// When tracking by Shipment reference you need to restrict the search by time frame. Please provide the start of the period.
        /// </summary>
        /// <example>2020-05-01</example>
        [ArgumentName("dateRangeFrom")]
        public DateOnly? DateRangeFrom { get; set; }

        /// <summary>
        /// When tracking by Shipment reference you need to restrict the search by time frame. Please provide the end of the period.
        /// </summary>
        /// <example>2020-06-01</example>
        [ArgumentName("dateRangeTo")]
        public DateOnly? DateRangeTo { get; set; }

        /// <summary>
        /// The tracking view
        /// </summary>
        [ArgumentName("trackingView")]
        [QueryArgumentConverter<TrackingViewQueryArgumentConverter>]
        public TrackingView? TrackingView { get; set; }

        /// <summary>
        /// The level of detail
        /// </summary>
        /// <example>all</example>
        [ArgumentName("levelOfDetail")]
        [QueryArgumentConverter<LevelOfDetailQueryArgumentConverter>]
        public LevelOfDetail? LevelOfDetail { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackMultipleShipmentAPIArgs() : base()
        {

        }

        #endregion
    }
}
