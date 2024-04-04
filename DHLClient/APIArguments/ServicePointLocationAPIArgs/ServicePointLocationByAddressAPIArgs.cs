namespace DHLClient
{
    /// <summary>
    /// Arguments uses for receiving a DHL service point location by address
    /// </summary>
    public class ServicePointLocationByAddressAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 code specifying the country.
        /// </summary>
        /// <example> DE </example>
        [ArgumentName("countryCode")]
        [QueryArgumentConverter<CountryCodeQueryArgymentConverter>]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Text specifying the name of the locality, for example a city.
        /// </summary>
        /// <example> Bonn </example>
        [ArgumentName("addressLocality")]
        public string? AddressLocality { get; set; }

        /// <summary>
        /// Text specifying the postal code for an address
        /// </summary>
        /// <example> 53113 </example>
        [ArgumentName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// The street address is expressed as free form text. The street address is printed on paper as the first
        /// lines below the name. For example, the name of the street and the number in the street, or the name of a building.
        /// </summary>
        /// <example> Charles-de-Gaulle-Str. 20 </example>
        [ArgumentName("streetAddress")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// This parameter allows to filter by DPDHL's internal Business Units. When this parameter is specified at least once per request,
        /// only locations known by that providerType (a.k.a Business Unit) will be returned. There may be locations with more than one providerType.
        /// The available providerTypes are: express (DHL Express Global), parcel (eCommerce Solutions Europe and Post & Parcel Germany)
        /// </summary>
        [ArgumentName("providerType")]
        [QueryArgumentConverter<ProviderTypeQueryArgumentConverter>]
        public ProviderType? ProviderType { get; set; }

        /// <summary>
        /// Type of the DHL Service Point location. This parameter can be added multiple times in each API request.
        /// The response will include only locations of the type that matches any of the requested ones.
        /// </summary>
        /// <example> servicepoint, locker, postoffice, postbank, pobox </example>
        [ArgumentName("locationType")]
        [QueryArgumentConverter<LocationTypeQueryArgumentConverter>]
        public LocationType? LocationType { get; set; }

        /// <summary>
        /// Each location can offer more than one service. This parameter can be added multiple times in each API request. The response will include 
        /// only locations with at least all of the serviceTypes requested. Only exception of this behaviour is parcel:pick-up-all, which includes any of the three parcel:pick-up services.
        /// </summary>
        [ArgumentName("serviceType")]
        [QueryArgumentConverter<ServiceTypeQueryArgumentConverter>]
        public ServiceType? ServiceType { get; set; }

        /// <summary>
        /// Specifies the radius in meters around the provided location, to search within. Maximum radius: 1 000 000 meters 
        /// (any radius greater than 1 000 000 will be considered as 1 000 000). Default radius: 5000 meters.
        /// </summary>
        [ArgumentName("radius")]
        public double? Radius { get; set; }

        /// <summary>
        /// Value specifying the maximum amount of locations included in the results. Maximum limit: 50 locations (any limit greater than 50 will be considered as 50). Default limit: 15 locations.
        /// </summary>
        [ArgumentName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// When set to true this parameter allows to exclude locations that have a closure period entry at the time of the request. 
        /// By default it is set to false and all locations are returned, whether they are showing closed or not.
        /// </summary>
        [ArgumentName("hideClosedLocations")]
        public bool? ShouldHideClosedLocations { get; set; }

        /// <summary>
        /// When any date is specified in this parameter then the API will exclude locations that have a closure period entry at the time of the specified date.
        /// Note:- currentDate will work only when parameter hideClosedLocations is
        /// </summary>
        [ArgumentName("currentDate")]
        public DateOnly? CurrentDate { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByAddressAPIArgs() : base()
        {

        }

        #endregion
    }
}