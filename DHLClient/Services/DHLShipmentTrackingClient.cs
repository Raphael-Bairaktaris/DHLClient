﻿namespace DHLClient
{
    /// <summary>
    /// An agent that is capable of making requests to the DHL shipment Tracking API
    /// </summary>
    public class DHLShipmentTrackingClient
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
        public DHLShipmentTrackingClient(DHLClientCredentials credentials) : base()
        {
            Client = WebRequestsClient.Instance;

            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the tracking information
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<ShipmentDetailResponseModel>> GetTrackingInfoAsync()
            => Client.GetAsync<ShipmentDetailResponseModel>(DHLClientShipmentTrackingAPIRoutes.RetrieveTrackingInfoAPIRoute, Credentials.APIKey);

        #endregion
    }
}