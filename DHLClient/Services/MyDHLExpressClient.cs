
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

        public Task<WebRequestResult<UploadPaperLessTradeShipmentResponseModel>> PatchPaperlessTradeShipmentAsync(string shipmentTrackingNumber)
            => Client.PatchAsync<UploadPaperLessTradeShipmentResponseModel>(MyDHLExpressClientAPIRoutes.PatchPaperlessTradeShipmentAPIRoute(shipmentTrackingNumber), null, Credentials.APIKey);

        /// <summary>
        /// Creates a DHL Express pickup request
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentResponseModel>> CreateDHLPickupAsync(CreateShipmentRequestModel model)
        {
            return await Client.PostAsync<ShipmentResponseModel>(MyDHLExpressClientAPIRoutes.CreateShipmentAPIRoute, model, Credentials.APIKey);
        }

        /// <summary>
        /// Upload commercial invoice data for you DHL Express shipment
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public Task<WebRequestResult<UploadCommercialInvoiceResponseModel>> AddCommercialInvoiceDataAsycn(string shipmentTrackingNumber)
            => Client.PatchAsync<UploadCommercialInvoiceResponseModel>(MyDHLExpressClientAPIRoutes.PatchCommercialInvoiceDataAPIRoute(shipmentTrackingNumber), null, Credentials.APIKey);

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
        public Task<WebRequestResult<UpdatePickupResponseModel>> UpdatePickupInformationAsync(string dispatchConfirmationNumber)
            => Client.PatchAsync<UpdatePickupResponseModel>(MyDHLExpressClientAPIRoutes.PatchPickupInformationForDHLPickupAPIRoute(dispatchConfirmationNumber), null, Credentials.APIKey);

        /// <summary>
        /// Creates a DHL Express pickup booking request
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<CreatePickupResponseModel>> CreateDHLPickupAsycn(CreatePickupResponseModel model)
        {
            return await Client.PostAsync<CreatePickupResponseModel>(MyDHLExpressClientAPIRoutes.CreateDHLPickupAPIRoute, model, Credentials.APIKey); 
        }

        #endregion

        #region Identifier

        /// <summary>
        /// Gets the identifiers upfront for DHL Express Breakbulk or Loose Break Bulk shipments
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<IdentifierResponseModel>> IdentifierAsync()
            => Client.GetAsync<IdentifierResponseModel>(MyDHLExpressClientAPIRoutes.IdentifiersAPIRoute, Credentials.APIKey);

        #endregion

        #region Address

        /// <summary>
        /// Gets the DHL Express pickup/delivery capabilities at origin/destination
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<AddressValidateResponseModel>> GetAddressAsync()
            => Client.GetAsync<AddressValidateResponseModel>(MyDHLExpressClientAPIRoutes.AddressAPIRoute, Credentials.APIKey);

        #endregion

        #region Invoice

        /// <summary>
        /// Upload commercial invoice data
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<InvoiceStatusResponseModel>> InvoiceAsync()
            => Client.PostAsync<InvoiceStatusResponseModel>(MyDHLExpressClientAPIRoutes.InvoiceAPIRoute, null, Credentials.APIKey);

        #endregion

        #region ServicePoint

        /// <summary>
        /// Gets the list of service points based on the given postal location address, service point Id or geocode details for DHL Express service points to pickup and drop-off shipments
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointResponseModel>> ServicePointAsync()
            => Client.GetAsync<ServicePointResponseModel>(MyDHLExpressClientAPIRoutes.ServicePointsAPIRoute, Credentials.APIKey);

        #endregion

        #region Reference Data

        /// <summary>
        /// Gets the reference data currently used for MyDHL API services usage
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<ReferenceDataResponseModel>> ReferenceDataAsync()
            => Client.GetAsync<ReferenceDataResponseModel>(MyDHLExpressClientAPIRoutes.ReferenceDataAPIRoute, Credentials.APIKey);

        #endregion

        #endregion
    }
}
