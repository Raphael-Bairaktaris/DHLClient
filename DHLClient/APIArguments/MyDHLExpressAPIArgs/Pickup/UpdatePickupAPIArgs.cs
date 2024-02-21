namespace DHLClient
{
    /// <summary>
    /// Arguments used for updating pickup
    /// </summary>
    public class UpdatePickupAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

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
        public UpdatePickupAPIArgs() : base()
        {

        }

        #endregion
    }
}
