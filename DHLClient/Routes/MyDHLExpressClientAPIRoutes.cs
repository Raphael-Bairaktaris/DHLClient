namespace DHLClient
{
    /// <summary>
    /// The API routes for DHL express client 
    /// </summary>
    public class MyDHLExpressClientAPIRoutes
    {
        /// <summary>
        /// Test environment to test your development against
        /// </summary>
        public const string TestEnvironment = "https://express.api.dhl.com/mydhlapi/test";

        /// <summary>
        /// Production environment to create real transactions with DHL Express
        /// </summary>
        public const string ProductionEnvironment = "https://express.api.dhl.com/mydhlapi";

        #region Rating API routes

        /// <summary>
        /// Retrieve rates for a one piece shipment
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetRetrieveOneShipmentRateAPIRoute(string? baseRoute) => Combine(baseRoute, "rates");

        /// <summary>
        /// Retrieve Rates for Multi-piece Shipments
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetRetrieveMultipleShipmentRatesAPIRoute(string? baseRoute) => Combine(baseRoute, "rates");

        /// <summary>
        /// The landed cost API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetLandedCostAPIRoute(string? baseRoute) => Combine(baseRoute, "landed-cost");

        #endregion

        #region Product API routes

        /// <summary>
        /// Retrieve available DHL Express products for a one piece Shipment
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetRetrieveProductsForOnePieceShipmentAPIRoute(string baseRoute) => Combine(baseRoute, "products");

        #endregion

        #region Shipment API routes

        /// <summary>
        /// The electronic proof of delivery API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public static string GetElectronicProofOfDeliveryAPIRoute(string baseRoute, string shipmentTrackingNumber) => Combine(baseRoute, "shipments", shipmentTrackingNumber, "proof-of-delivery");

        /// <summary>
        /// Upload Paperless Trade shipment (PLT) images of previously created shipment API route.
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public static string PatchPaperlessTradeShipmentAPIRoute(string baseRoute, string shipmentTrackingNumber) => Combine(baseRoute, "shipments", shipmentTrackingNumber, "upload-image");

        /// <summary>
        /// The create shipment API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetCreateShipmentAPIRoute(string baseRoute) => Combine(baseRoute, "shipments");

        /// <summary>
        /// Upload Commercial Invoice data for your DHL Express shipment API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public static string PatchCommercialInvoiceDataAPIRoute(string baseRoute,string shipmentTrackingNumber) => Combine(baseRoute, "shipments", shipmentTrackingNumber, "upload-invoice-data");

        /// <summary>
        /// Gets the shipment image
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public static string GetShipmentImageAPIRoute(string baseRoute, string shipmentTrackingNumber) => Combine(baseRoute, "shipments", shipmentTrackingNumber, "get-image");

        #endregion

        #region Tracking API routes

        /// <summary>
        /// Track a single DHL Express Shipment API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public static string GetSingleDHLShipment(string baseRoute, string shipmentTrackingNumber) => Combine(baseRoute, "shipments", shipmentTrackingNumber, "tracking");

        /// <summary>
        /// Track a single or multiple DHL Express Shipments API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetTrackDHLShipmentsAPIRoute(string baseRoute) => Combine(baseRoute, "tracking");

        #endregion

        #region Pickup API routes

        /// <summary>
        /// Cancel a DHL Express pickup booking request API route
        /// </summary>
        /// <param name="baseRoute"></param>
        /// <param name="dispatchConfirmationNumber"></param>
        /// <returns></returns>
        public static string DeletePickupAPIRoute(string baseRoute, string dispatchConfirmationNumber) => Combine(baseRoute, "pickups", dispatchConfirmationNumber);

        /// <summary>
        /// Update pickup information for an existing DHL Express pickup booking request API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <returns></returns>
        public static string PatchPickupInformationForDHLPickupAPIRoute(string baseRoute, string dispatchConfirmationNumber) => Combine(baseRoute, "pickups", dispatchConfirmationNumber);

        /// <summary>
        /// Create a DHL Express pickup booking request API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetCreateDHLPickupAPIRoute(string baseRoute) => Combine(baseRoute, "pickups");

        #endregion

        #region Identifier API routes

        /// <summary>
        /// Service to allocate identifiers upfront for DHL Express Break bulk or Loose Break Bulk shipments API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetIdentifiersAPIRoute(string baseRoute) => Combine(baseRoute, "identifiers");

        #endregion

        #region Address API routes

        /// <summary>
        /// Validate DHL Express pickup/delivery capabilities at origin/destination API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetValidateAddressAPIRoute(string baseRoute) => Combine(baseRoute, "address-validate");

        #endregion

        #region Invoice API routes

        /// <summary>
        /// Upload Commercial invoice data API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetInvoiceAPIRoute(string baseRoute) => Combine(baseRoute, "invoices", "upload-invoice-data");

        #endregion

        #region Service Point API routes

        /// <summary>
        /// Returns list of service points based on the given postal location address, 
        /// service point ID or geocode details for DHL Express Service points to pick-up and drop-off shipments API route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetServicePointsAPIRoute(string baseRoute) => Combine(baseRoute, "servicepoints");

        #endregion

        #region Reference Data API routes

        /// <summary>
        /// Provide reference data currently used for MyDHL API services usage API route.
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetReferenceDataAPIRoute(string baseRoute) => Combine(baseRoute, "reference-data");

        #endregion

        #region Public Methods

        /// <summary>
        /// Combines the specified <paramref name="parts"/> while ensuring a correct URL structure
        /// </summary>
        /// <returns></returns>
        public static string Combine(params string?[] parts)
        {
            var Parts = parts
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => x!.Trim('/'));

            return string.Join("/", Parts);
        }

        #endregion
    }
}
