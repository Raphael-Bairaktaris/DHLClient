namespace DHLClient
{
    /// <summary>
    /// Arguments used for receiving a DHL service point location by geo
    /// </summary>
    public class ServicePointLocationByGeoAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The latitude (only accepts values between -90 to 90 )
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude (only accepts values between -180 and 180)
        /// </summary>
        [ArgumentName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// his parameter allows to filter by DPDHL's internal Business Units. When this parameter is specified
        /// at least once per request, only locations known by that providerType (a.k.a Business Unit) will be returned. 
        /// There may be locations with more than one providerType.
        /// </summary>
        [ArgumentName("providerType")]
        public ProviderType? ProviderType { get; set; }

        /// <summary>
        /// Type of the DHL Service Point location. This parameter can be added multiple times in each API request.
        /// The response will include only locations of the type that matches any of the requested ones.
        /// </summary>
        [ArgumentName("locationType")]
        public LocationType? LocationType { get; set; }

        /// <summary>
        /// Each location can offer more than one service. This parameter can be added multiple times in each API request. The response will include only locations with at
        /// least all of the serviceTypes requested. Only exception of this behaviour is parcel:pick-up-all, which includes any of the three parcel:pick-up services.
        /// </summary>
        [ArgumentName("serviceType")]
        public ServiceType? ServiceType { get; set; }

        /// <summary>
        /// Specifies the radius in meters around the provided location, to search within.
        /// Maximum radius: 1 000 000 meters (any radius greater than 1 000 000 will be considered as 1 000 000). Default radius: 5000 meters.
        /// </summary>
        [ArgumentName("radius")]
        public double? Radius { get; set; }

        /// <summary>
        /// Number specifying the maximum amount of locations included in the results. 
        /// Maximum limit: 50 locations (any limit greater than 50 will be considered as 50). Default limit: 15 locations.
        /// </summary>
        [ArgumentName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 code specifying the country.
        /// </summary>
        [ArgumentName("countryCode")]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// When set to true this parameter allows to exclude locations that have a closure period entry at the time of the request.
        /// By default it is set to false and all locations are returned, whether they are showing closed or not.
        /// </summary>
        [ArgumentName("hideClosedLocations")]
        public bool? ShouldHideClosedLocations { get; set; }

        /// <summary>
        /// When any date is specified in this parameter then the api will exclude locations that have a closure period entry at the time of the specified date.
        /// Note:- currentDate will work only when parameter hideClosedLocations is set to true.
        /// </summary>
        [ArgumentName("currentDate")]
        public DateTime? CurrentDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByGeoAPIArgs() : base()
        {

        }

        #endregion
    }
}
