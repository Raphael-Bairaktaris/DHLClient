using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Arguments uses for receiving a shipment tracking by number
    /// </summary>
    public class ShipmentTrackingAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The tracking number of the shipment for which to return the information.
        /// </summary>
        [ArgumentName("trackingNumber")]
        public double TrackingNumber { get; set; }

        /// <summary>
        /// Hint which service (provider) should be used to resolve the tracking number.
        /// </summary>
        /// <example> express, parcel-de, ecommerce, dgf </example>
        [ArgumentName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// Optional ISO 3166-1 alpha-2 country code represents country of the consumer of the API response. It optimizes the return of the API response.
        /// </summary>
        [ArgumentName("requesterCountryCode")]
        [QueryArgumentConverter<CountryCodeQueryArgymentConverter>]
        public CountryCode? RequesterCountryCode { get; set; }

        /// <summary>
        /// Optional ISO 3166-1 alpha-2 country code of the shipment origin to further qualify the shipment tracking number 
        /// (trackingNumber) parameter of the request. This parameter is necessary to search for the shipment in dsc service.
        /// </summary>
        [ArgumentName("originCountryCode")]
        [QueryArgumentConverter<CountryCodeQueryArgymentConverter>]
        public CountryCode? OriginCountryCode { get; set; }

        /// <summary>
        /// Postal code of the destination address to
        /// <list type="bullet|number|table">
        ///     <item>further qualify the shipment tracking number (trackingNumber) parameter of the request or</item>
        ///     <item>parcel-nl and parcel-de services to display full set of data in the response.</item>
        /// </list>
        /// </summary>
        [ArgumentName("recipientPostalCode")]
        public string? RecipientPostalCode { get; set; }

        /// <summary>
        /// ISO 639-1 2-character language code for the response. This parameter serves as an indication of the client preferences ONLY.
        /// Language availability depends on the service used. The actual response language is indicated by the Content-Language header.
        /// </summary>
        [ArgumentName("language")]
        public CountryCode? Language { get; set; }

        /// <summary>
        /// Pagination parameter. Offset from the start of the result set at which to retrieve the remainder of the results (if any).
        /// </summary>
        [ArgumentName("offset")]
        public double Offset { get; set; }

        /// <summary>
        /// Pagination parameter. Maximal number of results to retrieve.
        /// </summary>
        [ArgumentName("limit")]
        public double Limit { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingAPIArgs() : base()
        {

        }

        #endregion
    }
}
