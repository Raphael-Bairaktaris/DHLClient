namespace DHLClient
{
    /// <summary>
    /// The API routes of DHL Shipment tracking Client
    /// </summary>
    public class DHLClientShipmentTrackingAPIRoutes
    {
        /// <summary>
        /// The base route for shipment tracking
        /// </summary>
        public const string BaseRoute = "https://api-eu.dhl.com/track/shipments";

        /// <summary>
        /// The retrieve shipment tracking information API route
        /// </summary>
        public const string RetrieveTrackingInfoAPIRoute = $"{BaseRoute}/shipments";
    }
}
