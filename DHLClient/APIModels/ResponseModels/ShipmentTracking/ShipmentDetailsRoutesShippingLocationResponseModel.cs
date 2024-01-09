namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details routes shipping location response
    /// </summary>
    public class ShipmentDetailsRoutesShippingLocationResponseModel
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
        public ShipmentDetailsRoutesShippingLocationResponseModel() : base()
        {

        }

        #endregion
    }
}