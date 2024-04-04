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
        public WebRequestsClient Client { get; }

        /// <summary>
        /// The credentials
        /// </summary>
        public DHLClientCredentials Credentials { get; }

        /// <summary>
        /// The base route
        /// </summary>
        public string BaseRoute { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="credentials">The credentials</param>
        /// <param name="shouldUseTestEnvironment"></param>
        public MyDHLExpressClient(DHLClientCredentials credentials, bool shouldUseTestEnvironment = false) : base()
        {
            Client = WebRequestsClient.Instance;

            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
            BaseRoute = shouldUseTestEnvironment ? MyDHLExpressClientAPIRoutes.TestEnvironment : MyDHLExpressClientAPIRoutes.ProductionEnvironment;
        }

        #endregion

        #region Public Methods

        #region Rating

        /// <summary>
        /// Gets the rate for one piece shipment
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetOneShipmentRateAsync(RetrieveShipmentRateAPIArgs args)
            => Client.GetAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.RetrieveOneShipmentRateAPIRoute, args), Credentials.Username);

        /// <summary>
        /// Retrieve rates for multiple piece shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetMultipleShipmentRatesAsync(RetrieveMultipleShipmentRateAPIArgs args, RatingRequestModel model)
            => Client.PostAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.RetrieveMultipleShipmentRatesAPIRoute, args), model, Credentials.Username);

        /// <summary>
        /// Gets the landed cost
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> CalculateLandedCostAsync(LandedCostAPIArgs args, RatingLandedCostRequestModel model)
            => Client.PostAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.LandedCostAPIRoute, args), model, Credentials.Username);

        #endregion

        #region Product

        /// <summary>
        /// Gets available DHL Express products for a one piece shipment
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<RatingProductResponseModel>> GetProductsForOnePieceShipmentAsync(ProductAPIArgs args)
            => Client.GetAsync<RatingProductResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.RetrieveProductsForOnePieceShipmentAPIRoute, args), Credentials.Username);

        #endregion

        #region Shipment

        /// <summary>
        /// Gets the electronic proof of delivery
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentProofOfDeliveryDocumentResponseModel>> GetElectronicProofOfDeliveryAsync(string shipmentTrackingNumber, ShipmentProofOfDeliveryAPIArgs args)
            => Client.GetAsync<ShipmentProofOfDeliveryDocumentResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.GetElectronicProofOfDeliveryAPIRoute(shipmentTrackingNumber), args), Credentials.Username);

        /// <summary>
        /// Upload paperless trade shipment (PLT) images of previously created shipment.
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult> PatchPaperlessTradeShipmentAsync(string shipmentTrackingNumber, ShipmentUploadPLTAPIArgs args, ShipmentUploadPLTRequestModel model)
        {
            return await Client.PatchAsync<object>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.PatchPaperlessTradeShipmentAPIRoute(shipmentTrackingNumber), args), model, Credentials.Username);
        }

        /// <summary>
        /// Creates a DHL Express shipment request
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentResponseModel>> CreateDHLShipmentAsync(CreateShipmentAPIArgs args ,CreateShipmentRequestModel model)
        {
            return await Client.PostAsync<ShipmentResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.CreateShipmentAPIRoute, args), model, Credentials.Username);
        }

        /// <summary>
        /// Upload commercial invoice data for you DHL Express shipment
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<UploadCommercialInvoiceResponseModel>> AddCommercialInvoiceDataAsycn(string shipmentTrackingNumber, UploadCommercialInvoiceForShipmentAPIArgs args, UploadInvoiceDataRequestModel model)
            => Client.PatchAsync<UploadCommercialInvoiceResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.PatchCommercialInvoiceDataAPIRoute(shipmentTrackingNumber), args), model, Credentials.Username);

        /// <summary>
        /// Gets the shipment image
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentImageResponseModel>> GetShipmentImageAsync(string shipmentTrackingNumber, ShipmentGetImageAPIArgs args)
            => Client.GetAsync<ShipmentImageResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.GetShipmentImageAPIRoute(shipmentTrackingNumber), args), Credentials.Username);

        #endregion

        #region Tracking

        /// <summary>
        /// Gets a single DHL Express shipment
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentTrackingSchemaResponseModel>> GetSingleDHLShipmentAsync(string shipmentTrackingNumber, TrackSingleShipmentAPIArgs args)
            => Client.GetAsync<ShipmentTrackingSchemaResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.GetSingleDHLShipment(shipmentTrackingNumber), args), Credentials.Username);

        /// <summary>
        /// Get a single or multiple DHL Express shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentTrackingSchemaResponseModel>> GetMultipleDHLShipmentsAsync(TrackMultipleShipmentAPIArgs args)
            => Client.GetAsync<ShipmentTrackingSchemaResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.TrackDHLShipmentsAPIRoute, args), Credentials.Username);

        #endregion

        #region Pickup

        /// <summary>
        /// Deletes a DHL Express pickup booking request
        /// </summary>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<CancelPickupResponseModel>> DeletePickupAsync(string dispatchConfirmationNumber, CancelPickupAPIArgs args)
            => Client.DeleteAsync<CancelPickupResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.DeletePickupAPIRoute(dispatchConfirmationNumber), args), Credentials.Username);

        /// <summary>
        /// Updates the pickup information for an existing DHL Express pickup
        /// </summary>
        /// <param name="dispatchConfirmationNumber">The dispatch confirmation number</param>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<UpdatePickupResponseModel>> UpdatePickupInformationAsync(string dispatchConfirmationNumber, UpdatePickupAPIArgs args, UpdatePickupRequestModel model)
            => Client.PatchAsync<UpdatePickupResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.PatchPickupInformationForDHLPickupAPIRoute(dispatchConfirmationNumber), args), model, Credentials.Username);

        /// <summary>
        /// Creates a DHL Express pickup booking request
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<CreatePickupResponseModel>> CreateDHLPickupAsycn(CreatePickupAPIArgs args ,CreatePickupResponseModel model)
        {
            return await Client.PostAsync<CreatePickupResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.CreateDHLPickupAPIRoute, args), model, Credentials.Username); 
        }

        #endregion

        #region Identifier

        /// <summary>
        /// Gets the identifiers upfront for DHL Express Break bulk or Loose Break Bulk shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<IdentifierResponseModel>> IdentifierAsync(IdentifierAPIArgs args)
            => Client.GetAsync<IdentifierResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.IdentifiersAPIRoute, args), Credentials.Username);

        #endregion

        #region Address

        /// <summary>
        /// Gets the DHL Express pickup/delivery capabilities at origin/destination
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<AddressValidateResponseModel>> GetAddressValidationAsync(ValidateAddressAPIArgs args)
            => Client.GetAsync<AddressValidateResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.ValidateAddressAPIRoute, args), Credentials.Username);

        #endregion

        #region Invoice

        /// <summary>
        /// Upload commercial invoice data
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<InvoiceStatusResponseModel>> InvoiceAsync(UploadCommercialInvoiceDataAPIArgs args)
            => Client.PostAsync<InvoiceStatusResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.InvoiceAPIRoute, args), null, Credentials.Username);

        #endregion

        #region ServicePoint

        /// <summary>
        /// Gets the list of service points based on the given postal location address, service point Id or geocode details for DHL Express service points to pickup and drop-off shipments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ServicePointResponseModel>> ServicePointAsync(ServicepointAPIArgs args)
            => Client.GetAsync<ServicePointResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.ServicePointsAPIRoute, args), Credentials.Username);

        #endregion

        #region Reference Data

        /// <summary>
        /// Gets the reference data currently used for MyDHL API services usage
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<ReferenceDataResponseModel>> ReferenceDataAsync(ReferenceDataAPIArgs args)
            => Client.GetAsync<ReferenceDataResponseModel>(RouteHelpers.AttachParameters(MyDHLExpressClientAPIRoutes.ReferenceDataAPIRoute, args), Credentials.Username);

        #endregion

        #endregion
    }
}