namespace DHLClient
{
    /// <summary>
    /// The arguments used for receiving a DHL service point location by id
    /// </summary>
    public class ServicePointLocationByIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// ID of the DHL Service Point location.
        /// </summary>
        [ArgumentName("id")]
        public string? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
