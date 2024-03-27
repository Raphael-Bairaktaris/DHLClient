namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the tracking view types
    /// </summary>
    public enum TrackingView
    {
        /// <summary>
        /// All checkpoints
        /// </summary>
        AllCheckpoints = 0,

        /// <summary>
        /// All checkpoints with remarks
        /// </summary>
        AllCheckPointsWithRemarks =1,

        /// <summary>
        /// Last checkpoint
        /// </summary>
        LastCheckpoint = 2,

        /// <summary>
        /// Shipment details only
        /// </summary>
        ShipmentDetailsOnly = 3,

        /// <summary>
        /// Advance shipment
        /// </summary>
        AdvanceShipment = 4,

        /// <summary>
        /// Bbx children
        /// </summary>
        BbxChildren = 5
    }
}
