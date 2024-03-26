namespace DHLClient
{
    /// <summary>
    /// The API routes of DHL Location finder API
    /// </summary>
    public class DHLClientLocationAPIRoutes
    {
        /// <summary>
        /// The location base route
        /// </summary>
        public const string LocationBaseRoute = "https://api.dhl.com/location-finder/v1";

        /// <summary>
        /// The location finder by address route
        /// </summary>
        public const string LocationByAddressAPIRoute = $"{LocationBaseRoute}/find-by-address";

        /// <summary>
        /// The location finder by geo route
        /// </summary>
        public const string FindByGeoAPIRoute = $"{LocationBaseRoute}/find-by-geo";

        /// <summary>
        /// The location finder by keyword id route
        /// </summary>
        public const string FindByKeywordIdAPIRoute = $"{LocationBaseRoute}/find-by-keyword-id";

        /// <summary>
        /// The DHL service point location by it's id route
        /// </summary>
        public static string GetLocationByIdAPIRoute(string locationId) => $"{LocationBaseRoute}/locations/{locationId}";
    }
}
