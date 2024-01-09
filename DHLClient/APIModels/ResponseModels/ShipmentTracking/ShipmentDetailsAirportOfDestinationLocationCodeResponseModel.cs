namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details airport of destination location code response
    /// </summary>
    public class ShipmentDetailsAirportOfDestinationLocationCodeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="SuperModelIoSchemaOrganizationPropertiesIataCode"/>
        /// </summary>
        private ShipmentDetailsAirportOfDestinationSuperModelIoSchemaOrganizationPropertiesIataCodeResponseModel? mSuperModelIoSchemaOrganizationPropertiesIataCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The super model io schema organization properties iata code
        /// </summary>
        public ShipmentDetailsAirportOfDestinationSuperModelIoSchemaOrganizationPropertiesIataCodeResponseModel SuperModelIoSchemaOrganizationPropertiesIataCode
        {
            get => mSuperModelIoSchemaOrganizationPropertiesIataCode ??= new ShipmentDetailsAirportOfDestinationSuperModelIoSchemaOrganizationPropertiesIataCodeResponseModel();
            set => mSuperModelIoSchemaOrganizationPropertiesIataCode = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsAirportOfDestinationLocationCodeResponseModel() : base()
        {

        }

        #endregion
    }
}