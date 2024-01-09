namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details airport of destination country code response
    /// </summary>
    public class ShipmentDetailsAirportOfDestinationCountryCodeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="SuperModelIoGs1PropertiesCountryCode"/> property
        /// </summary>
        private string? mSuperModelIoGs1PropertiesCountryCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The super model Io Gs1 properties country code
        /// </summary>
        public string SuperModelIoGs1PropertiesCountryCode
        {
            get => mSuperModelIoGs1PropertiesCountryCode ?? string.Empty;
            set => mSuperModelIoGs1PropertiesCountryCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsAirportOfDestinationCountryCodeResponseModel() : base()
        {

        }

        #endregion
    }
}