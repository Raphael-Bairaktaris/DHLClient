namespace DHLClient.MyDHLExpress
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
        public long AccountNumber { get; set; }

        /// <summary>
        /// Type of DHL express identifier to retrieve
        /// </summary>
        [ArgumentName("type")]
        [QueryArgumentConverter<IdentifierTypeQueryArgumentConverter>]
        public IdentifierType IdentifierType { get; set; }

        /// <summary>
        /// Value of identifiers to be retrieved
        /// </summary>
        [ArgumentName("size")]
        public int Size { get; set; }

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
