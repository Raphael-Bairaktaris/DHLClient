namespace DHLClient
{
    /// <summary>
    /// Arguments used for canceling pickup
    /// </summary>
    public class CancelPickupAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Name of the person requesting to cancel the scheduled pickup
        /// </summary>
        /// <example>Fred Brent</example>
        [ArgumentName("requestorName")]
        public string? RequestorName { get; set; }

        /// <summary>
        /// Provide why scheduled pickup is canceled
        /// </summary>
        /// <example>Unplanned leave</example>
        [ArgumentName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Shipment pickup confirmation number for example
        /// </summary>
        /// <example>PRG999126012345</example>
        [ArgumentName("dispatchConfirmationNumber")]
        public string? DispatchConfirmationNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelPickupAPIArgs() : base()
        {

        }

        #endregion
    }
}
