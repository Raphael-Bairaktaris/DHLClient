namespace DHLClient
{
    /// <summary>
    /// Arguments used for identifier
    /// </summary>
    public class IdentifierAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// DHL Express customer account number
        /// </summary>
        [ArgumentName("accountNumber")]
        public double AccountNumber { get; set; }

        /// <summary>
        /// Type of DHL express identifier to retrieve
        /// </summary>
        [ArgumentName("type")]
        [QueryArgumentConverter<IdentifierTypeQueryArgumentConverter>]
        public IdentifierType Type { get; set; }

        /// <summary>
        /// Value of identifiers to be retrieved
        /// </summary>
        [ArgumentName("size")]
        public double Size { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifierAPIArgs() : base()
        {

        }

        #endregion
    }
}
