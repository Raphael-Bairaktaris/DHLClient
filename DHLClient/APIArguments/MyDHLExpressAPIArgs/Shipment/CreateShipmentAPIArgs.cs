namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Arguments used for creating shipment
    /// </summary>
    public class CreateShipmentAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// If set to true, indicate strict DCT validation of address details, and validation of product and service(s) combination provided in request.
        /// </summary>
        [ArgumentName("strictValidation")]
        public bool? HasStrictValidation { get; set; }

        /// <summary>
        /// Option to bypass PLT - WY service code lane capability validation
        /// </summary>
        [ArgumentName("bypassPLTError")]
        public bool? ShouldBypassPLTError { get; set; }

        /// <summary>
        /// If set to true, indicate to perform shipment data compliant validation on the shipment information.
        /// </summary>
        [ArgumentName("validateDataOnly")]
        public bool? ShouldValidateDataOnly { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateShipmentAPIArgs() : base()
        {

        }

        #endregion
    }
}
