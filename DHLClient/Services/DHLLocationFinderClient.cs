namespace DHLClient
{
    /// <summary>
    /// An agent that is capable of making requests to the DHL Location Finder API
    /// </summary>
    public class DHLLocationFinderClient
    {
        #region Public Properties

        /// <summary>
        /// The client
        /// </summary>
        public WebRequestsClient Client { get; }

        /// <summary>
        /// The credentials
        /// </summary>
        public DHLClientCredentials Credentials { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="credentials">The credentials</param>
        public DHLLocationFinderClient(DHLClientCredentials credentials) : base()
        {
            Client = WebRequestsClient.Instance; 

            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the DHL service point location by address
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointLocationByAddressResponseModel>> GetLocationByAddressAsync(ServicePointLocationByAddressAPIArgs args)
            => Client.GetAsync<ServicePointLocationByAddressResponseModel>(RouteHelpers.AttachParameters(DHLClientLocationAPIRoutes.LocationByAddressAPIRoute, args), Credentials.Username);

        /// <summary>
        /// Gets the location by geographical coordinates
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointLocationByGeoResponseModel>> GetLocationByGeoAsync(ServicePointLocationByGeoAPIArgs args)
            => Client.GetAsync<ServicePointLocationByGeoResponseModel>(RouteHelpers.AttachParameters(DHLClientLocationAPIRoutes.FindByGeoAPIRoute, args), Credentials.Username);

        /// <summary>
        /// Gets the DHL service point location by keywordId
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointLocationByIdResponseModel>> GetLocationByKeywordIdAsync(ServicePointLocationByKeywordIdAPIArgs args)
            => Client.GetAsync<ServicePointLocationByIdResponseModel>(RouteHelpers.AttachParameters(DHLClientLocationAPIRoutes.FindByKeywordIdAPIRoute, args), Credentials.Username);

        /// <summary>
        /// Gets one DHL service point location by it's Id
        /// </summary>
        /// <param name="keywordId">The keyword Id</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointLocationByIdResponseModel>> GetLocationByIdAsync(string keywordId, ServicePointLocationByIdAPIArgs args)
            => Client.GetAsync<ServicePointLocationByIdResponseModel>(RouteHelpers.AttachParameters(DHLClientLocationAPIRoutes.GetLocationByIdAPIRoute(keywordId), args), Credentials.Username);

        #endregion
    }
}
