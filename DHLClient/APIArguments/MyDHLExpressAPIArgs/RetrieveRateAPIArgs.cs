namespace DHLClient
{
    /// <summary>
    /// Arguments used for retrieving rate
    /// </summary>
    public class RetrieveRateAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// If set to true, indicate strict DCT validation of address details, and validation of product and service(s) combination provided in request.
        /// </summary>
        [ArgumentName("strictValidation")]
        public bool ShouldStrictValidation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RetrieveRateAPIArgs() : base()
        {

        }

        #endregion
    }
}
