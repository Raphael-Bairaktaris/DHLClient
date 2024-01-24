namespace DHLClient
{
    /// <summary>
    /// Represents a service point address response
    /// </summary>
    public class ServicePointAddressResponseModel
    {
        #region Public Properties

        /// <summary>
        /// First line of the facility address
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the facility address (only present if field is filled in GREF database)
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the facility address (only present if field is filled in GREF database)
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Street details in facility address
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// House number in facility address
        /// </summary>
        public double Number { get; set; }

        /// <summary>
        /// Additional details in facility address
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Facility city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Zip code of the facility
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The country
        /// </summary>
        public CountryCode Country { get; set; }

        /// <summary>
        /// The DHL country
        /// </summary>
        public string DHLCountry { get; set; }

        /// <summary>
        /// The country division code
        /// </summary>
        public string CountryDivisionCode { get; set; }

        /// <summary>
        /// The country division code type
        /// </summary>
        public string CountryDivisionCodeType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointAddressResponseModel() : base()
        {

        }

        #endregion
    }
}