namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the delivery options
    /// </summary>
    public enum DeliveryOption
    {
        /// <summary>
        /// Service point
        /// </summary>
        ServicePoint = 0,

        /// <summary>
        /// Neighbour
        /// </summary>
        Neighbour = 1,

        /// <summary>
        /// Signature release
        /// </summary>
        SignatureRelease = 2,

        /// <summary>
        /// Concierge
        /// </summary>
        Concierge = 3
    }
}
