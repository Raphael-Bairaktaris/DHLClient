namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the identifier types
    /// </summary>
    public enum IdentifierType
    {
        /// <summary>
        /// Shipment Id
        /// </summary>
        SID = 0,

        /// <summary>
        /// Pid
        /// </summary>
        PID = 1,

        /// <summary>
        /// Advanced shipment of three (3) months
        /// </summary>
        ASID3 = 2,

        /// <summary>
        /// Advanced shipment of six (6) months
        /// </summary>
        ASID6 = 3,

        /// <summary>
        /// Advances Shipment of twelve (12) months
        /// </summary>
        ASID12 = 4,

        /// <summary>
        /// Advances Shipment of twenty four (24) months
        /// </summary>
        ASID24 = 5,

        /// <summary>
        /// Handling Unit ID
        /// </summary>
        HUID = 6
    }
}