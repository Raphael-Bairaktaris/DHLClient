namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Arguments used for retrieving rate
    /// </summary>
    public class RetrieveMultipleShipmentRateAPIArgs : BaseMyDHLAPIArgs
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
        public RetrieveMultipleShipmentRateAPIArgs() : base()
        {

        }

        #endregion
    }
}
