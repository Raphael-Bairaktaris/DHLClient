namespace DHLClient
{
    /// <summary>
    /// Provides enumeration over the service point status types
    /// </summary>
    public enum ServicepointStatus
    {
        /// <summary>
        /// Service Available (Open) (A)
        /// </summary>
        ServiceAvailable = 0,

        /// <summary>
        /// Service Suspended (Temporarily Closed) (S)
        /// </summary>
        ServiceSuspended = 1,

        /// <summary>
        /// Service Unavailable (Temporarily Closed) (U)
        /// </summary>
        ServiceUnavailable = 2,

        /// <summary>
        /// Closed (Temporarily Closed) (X)
        /// </summary>
        Closed = 3,

        /// <summary>
        /// Not Yet Open (Temporarily Closed) (Y)
        /// </summary>
        NotYetOpen = 4
    }
}
