namespace DHLClient
{
    /// <summary>
    /// The arguments used for receiving a DHL service point location by keyword id
    /// </summary>
    public class ServicePointLocationByKeywordIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Id belonging to keyword that builds the streetAddress for direct addressing to a service point or locker for pick up / drop off.
        /// </summary>
        [ArgumentName("keywordId")]
        public string? KeywordId { get; set; }

        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 code specifying the country.
        /// </summary>
        [ArgumentName("countryCode")]
        public CountryCodeType? CountryCode { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address.
        /// </summary>
        [ArgumentName("postalCode")]
        public string? PostalCode { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByKeywordIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
