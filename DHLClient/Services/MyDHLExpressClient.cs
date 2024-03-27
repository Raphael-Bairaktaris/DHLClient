
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
        public Task<WebRequestResult<RatingProductResponseModel>> GetOneShipmentRateAsync(RetrieveShipmentRateAPIArgs args)
            => Client.GetAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.RetrieveOneShipmentRateAPIRoute, args), Credentials.APIKey);

        /// <summary>
        /// Retrieve rates for multiple piece shipments
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetMultipleShipmentRatesAsync(RetrieveMultipleShipmentRateAPIArgs args, RatingRequestModel model)
            => Client.PostAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.RetrieveMultipleShipmentRatesAPIRoute, args), model, Credentials.APIKey);

        /// <summary>
        /// Gets the landed cost
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> CalculateLandedCostAsync(LandedCostAPIArgs args, RatingLandedCostRequestModel model)
            => Client.PostAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.LandedCostAPIRoute, args), model, Credentials.APIKey);

        #endregion

        #region Product

        /// <summary>
        /// Gets available DHL Express products for a one piece shipment
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetProductsForOnePieceShipmentAsync(ProductAPIArgs args)
            => Client.GetAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.RetrieveProductsForOnePieceShipmentAPIRoute, args), Credentials.APIKey);

        #endregion

        #region Shipment

        /// <summary>
        /// Gets the electronic proof of delivery
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentProofOfDeliveryDocumentResponseModel>> GetElectronicProofOfDeliveryAsync(string shipmentTrackingNumber, ShipmentProofOfDeliveryAPIArgs args)
            => Client.GetAsync<ShipmentProofOfDeliveryDocumentResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.GetElectronicProofOfDeliveryAPIRoute(shipmentTrackingNumber), args), Credentials.APIKey);

        /// <summary>
        /// Upload paperless trade shipment (PLT) images of previously created shipment.
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult> PatchPaperlessTradeShipmentAsync(string shipmentTrackingNumber, ShipmentUploadPLTAPIArgs args, ShipmentUploadPLTRequestModel model)
        {
            return await Client.PatchAsync<object>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.PatchPaperlessTradeShipmentAPIRoute(shipmentTrackingNumber), args), model, Credentials.APIKey);
        }

        /// <summary>
        /// Creates a DHL Express pickup request
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentResponseModel>> CreateDHLPickupAsync(CreateShipmentAPIArgs args ,CreateShipmentRequestModel model)
        {
            return await Client.PostAsync<ShipmentResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.CreateShipmentAPIRoute, args), model, Credentials.APIKey);
        }

        /// <summary>
        /// Upload commercial invoice data for you DHL Express shipment
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<UploadCommercialInvoiceResponseModel>> AddCommercialInvoiceDataAsycn(string shipmentTrackingNumber, UploadCommercialInvoiceForShipmentAPIArgs args, UploadInvoiceDataRequestModel model)
            => Client.PatchAsync<UploadCommercialInvoiceResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.PatchCommercialInvoiceDataAPIRoute(shipmentTrackingNumber), args), model, Credentials.APIKey);

        /// <summary>
        /// Gets the shipment image
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentImageResponseModel>> GetShipmentImageAsync(string shipmentTrackingNumber, ShipmentGetImageAPIArgs args)
            => Client.GetAsync<ShipmentImageResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.GetShipmentImageAPIRoute(shipmentTrackingNumber), args), Credentials.APIKey);

        #endregion

        #region Tracking

        /// <summary>
        /// Gets a single DHL Express shipment
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentTrackingSchemaResponseModel>> GetSingleDHLShipmentAsync(string shipmentTrackingNumber, TrackSingleShipmentAPIArgs args)
            => Client.GetAsync<ShipmentTrackingSchemaResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.GetSingleDHLShipment(shipmentTrackingNumber), args), Credentials.APIKey);

        /// <summary>
        /// Get a single or multiple DHL Express shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentTrackingSchemaResponseModel>> GetMultipleDHLShipmentsAsync(TrackMultipleShipmentAPIArgs args)
            => Client.GetAsync<ShipmentTrackingSchemaResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.TrackDHLShipmentsAPIRoute, args), Credentials.APIKey);

        #endregion

        #region Pickup

        /// <summary>
        /// Deletes a DHL Express pickup booking request
        /// </summary>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<CancelPickupResponseModel>> DeletePickupAsync(string dispatchConfirmationNumber, CancelPickupAPIArgs args)
            => Client.DeleteAsync<CancelPickupResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.DeletePickupAPIRoute(dispatchConfirmationNumber), args), Credentials.APIKey);

        /// <summary>
        /// Updates the pickup information for an existing DHL Express pickup
        /// </summary>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<UpdatePickupResponseModel>> UpdatePickupInformationAsync(string dispatchConfirmationNumber, UpdatePickupAPIArgs args, UpdatePickupRequestModel model)
            => Client.PatchAsync<UpdatePickupResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.PatchPickupInformationForDHLPickupAPIRoute(dispatchConfirmationNumber), args), model, Credentials.APIKey);

        /// <summary>
        /// Creates a DHL Express pickup booking request
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<CreatePickupResponseModel>> CreateDHLPickupAsycn(CreatePickupAPIArgs args ,CreatePickupResponseModel model)
        {
            return await Client.PostAsync<CreatePickupResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.CreateDHLPickupAPIRoute, args), model, Credentials.APIKey); 
        }

        #endregion

        #region Identifier

        /// <summary>
        /// Gets the identifiers upfront for DHL Express Break bulk or Loose Break Bulk shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<IdentifierResponseModel>> IdentifierAsync(IdentifierAPIArgs args)
            => Client.GetAsync<IdentifierResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.IdentifiersAPIRoute, args), Credentials.APIKey);

        #endregion

        #region Address

        /// <summary>
        /// Gets the DHL Express pickup/delivery capabilities at origin/destination
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<AddressValidateResponseModel>> GetAddressValidationAsync(ValidateAddressAPIArgs args)
            => Client.GetAsync<AddressValidateResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.ValidateAddressAPIRoute, args), Credentials.APIKey);

        #endregion

        #region Invoice

        /// <summary>
        /// Upload commercial invoice data
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<InvoiceStatusResponseModel>> InvoiceAsync(UploadCommercialInvoiceDataAPIArgs args)
            => Client.PostAsync<InvoiceStatusResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.InvoiceAPIRoute, args), null, Credentials.APIKey);

        #endregion

        #region ServicePoint

        /// <summary>
        /// Gets the list of service points based on the given postal location address, service point Id or geocode details for DHL Express service points to pickup and drop-off shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointResponseModel>> ServicePointAsync(ServicepointAPIArgs args)
            => Client.GetAsync<ServicePointResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.ServicePointsAPIRoute, args), Credentials.APIKey);

        #endregion

        #region Reference Data

        /// <summary>
        /// Gets the reference data currently used for MyDHL API services usage
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ReferenceDataResponseModel>> ReferenceDataAsync(ReferenceDataAPIArgs args)
            => Client.GetAsync<ReferenceDataResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.ReferenceDataAPIRoute, args), Credentials.APIKey);

        #endregion

        #endregion
    }
}