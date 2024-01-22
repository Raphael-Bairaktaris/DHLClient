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
        /// Last checkpoint
        /// </summary>
        LastCheckpoint = 1,

        /// <summary>
        /// Shipment details only
        /// </summary>
        ShipmentDetailsOnly = 2,

        /// <summary>
        /// Advance shipment
        /// </summary>
        AdvanceShipment = 3,

        /// <summary>
        /// Bbx children
        /// </summary>
        BbxChildren = 4
    }
}
