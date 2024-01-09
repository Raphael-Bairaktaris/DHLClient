namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the status code
    /// </summary>
    public enum StatusCodeType
    {
        /// <summary>
        /// Pre transit
        /// </summary>
        PreTransit = 0,

        /// <summary>
        /// Transit
        /// </summary>
        Transit = 1,

        /// <summary>
        /// Delivered
        /// </summary>
        Delivered = 2,

        /// <summary>
        /// Failure
        /// </summary>
        Failure = 3,

        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 4
    }
}
