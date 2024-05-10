namespace DHLClient
{
    /// <summary>
    /// Arguments used for validating an address
    /// </summary>
    public class ValidateAddressAPIArgs : BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The delivery option types
        /// </summary>
        [ArgumentName("type")]
        [QueryArgumentConverter<DeliveryServiceQueryArgumentConverter>]
        public DeliveryService? DeliveryService { get; set; }

        /// <summary>
        /// A short text string code (see values defined in ISO 3166) specifying the shipment origin country
        /// </summary>
        [ArgumentName("countryCode")]
        [QueryArgumentConverter<CountryCodeQueryArgymentConverter>]
        public CountryCode? CountryCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ValidateAddressAPIArgs() : base()
        {

        }

        #endregion
    }
}
