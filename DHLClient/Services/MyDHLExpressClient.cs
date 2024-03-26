namespace DHLClient
{
    /// <summary>
    /// An agent that is capable of making requests to the MyDHL Express API
    /// </summary>
    public class MyDHLExpressClient
    {
        #region Public Properties

        /// <summary>
        /// The client
        /// </summary>
        public WebRequestsClient Client;

        /// <summary>
        /// The credentials
        /// </summary>
        public DHLClientCredentials Credentials;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="credentials">The credentials</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MyDHLExpressClient(DHLClientCredentials credentials) : base()
        {
            Client = WebRequestsClient.Instance;

            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
        }

        #endregion

        #region Public Methods

        #region Rating

        /// <summary>
        /// Gets the rate for one piece shipment
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetOneShipmentRateAsync()
            => Client.GetAsync<RatingProductResponseModel>(MyDHLExpressClientAPIRoutes.RetrieveOneShipmentRateAPIRoute, Credentials.APIKey);

        /// <summary>
        /// Retrieve rates for multiple piece shipments
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingRequestModel>> PostMultipleShipmentRateAsync()
            => Client.PostAsync<RatingRequestModel>(MyDHLExpressClientAPIRoutes.RetrieveMultipleShipmentRatesAPIRoute, null, Credentials.APIKey);

        /// <summary>
        /// Gets the landed cost
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingLandedCostRequestModel>> PostLandedCostAsync()
            => Client.PostAsync<RatingLandedCostRequestModel>(MyDHLExpressClientAPIRoutes.LandedCostAPIRoute, null, Credentials.APIKey);

        #endregion

        #region Product

        /// <summary>
        /// Gets available DHL Express products for a one piece shipment
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetProductsForOnePieceShipmentAsync()
            => Client.GetAsync<RatingProductResponseModel>(MyDHLExpressClientAPIRoutes.RetrieveProductsForOnePieceShipmentAPIRoute, Credentials.APIKey);

        #endregion

        #region Shipment

        /// <summary>
        /// Gets the electronic proof of delivery
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentProofOfDeliveryDocumentResponseModel>> GetElectronicProofOfDeliveryAsync(string shipmentTrackingNumber)
            => Client.GetAsync<ShipmentProofOfDeliveryDocumentResponseModel>(MyDHLExpressClientAPIRoutes.GetElectronicProofOfDeliveryAPIRoute(shipmentTrackingNumber), Credentials.APIKey);

        public Task<WebRequestResult<ShipmentUploadPLTRequestModel>> PatchPaperlessTradeShipmentAsync(string shipmentTrackingNumber)
            => Client.PatchAsync<ShipmentUploadPLTRequestModel>(MyDHLExpressClientAPIRoutes.PatchPaperlessTradeShipmentAPIRoute(shipmentTrackingNumber), null, Credentials.APIKey);

        /// <summary>
        /// Creates a DHL Express pickup request
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentResponseModel>> CreateDHLPickupAsync(CreateShipmentRequestModel model)
        {
            return await Client.PostAsync<ShipmentResponseModel>(MyDHLExpressClientAPIRoutes.CreateShipmentAPIRoute, model, Credentials.APIKey);
        }

        #endregion

        #region Tracking

        /// <summary>
        /// Gets a single DHL Express shipment
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentTrackingSchemaResponseModel>> GetSingleDHLShipmentAsync(string shipmentTrackingNumber)
            => Client.GetAsync<ShipmentTrackingSchemaResponseModel>(MyDHLExpressClientAPIRoutes.GetSingleDHLShipment(shipmentTrackingNumber), Credentials.APIKey);

        /// <summary>
        /// Get a single or multiple DHL Express shipments
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentTrackingSchemaResponseModel>> GetDHLShipmentsAsync()
            => Client.GetAsync<ShipmentTrackingSchemaResponseModel>(MyDHLExpressClientAPIRoutes.TrackDHLShipmentsAPIRoute, Credentials.APIKey);

        #endregion

        #region Pickup

        /// <summary>
        /// Deletes a DHL Express pickup booking request
        /// </summary>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <returns></returns>
        public Task<WebRequestResult<CancelPickupResponseModel>> DeletePickupAsync(string dispatchConfirmationNumber)
            => Client.DeleteAsync<CancelPickupResponseModel>(MyDHLExpressClientAPIRoutes.DeletePickupAPIRoute(dispatchConfirmationNumber), Credentials.APIKey);

        /// <summary>
        /// Updates the pickup information for an existing DHL Express pickup
        /// </summary>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<UpdatePickupResponseModel>> UpdatePickupInformationAsync(string dispatchConfirmationNumber, UpdatePickupRequestModel model)
            => Client.PutAsync<UpdatePickupRequestModel>(MyDHLExpressClientAPIRoutes.PatchPickupInformationForDHLPickupAPIRoute(dispatchConfirmationNumber), model, Credentials.APIKey);

        #endregion

        #endregion
    }
}
