using DHLClient.DataModels.Enums;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details provider response
    /// </summary>
    public class ShipmentDetailsProviderResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The name of the provider organization handling the delivery in the destination country.
        /// </summary>
        public DestinationProvider DestinationProvider { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsProviderResponseModel() : base()
        {

        }

        #endregion
    }
}