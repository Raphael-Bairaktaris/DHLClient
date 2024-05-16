using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a shipment details routes shipping location response
    /// </summary>
    public class ShipmentDetailsShippingRouteLocationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="LocationName"/> property
        /// </summary>
        private string? mLocationName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The location Name
        /// </summary>
        [JsonProperty("locationName")]
        public string LocationName
        {
            get => mLocationName ?? string.Empty;
            set => mLocationName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsShippingRouteLocationResponseModel() : base()
        {

        }

        #endregion
    }
}