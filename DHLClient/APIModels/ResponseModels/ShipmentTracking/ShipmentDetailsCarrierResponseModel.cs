namespace DHLClient
{
    public class ShipmentDetailsCarrierResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OrganizationName"/> property
        /// </summary>
        private string? mOrganizationName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The organization name
        /// </summary>
        public string? OrganizationName
        {
            get => mOrganizationName ?? string.Empty;
            set => mOrganizationName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsCarrierResponseModel() : base()
        {

        }

        #endregion
    }
}
