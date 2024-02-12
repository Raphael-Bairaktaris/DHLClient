using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment detail organization name response
    /// </summary>
    public class ShipmentDetailOrganizationNameResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="OrganizationName"/> property
        /// </summary>
        private string? mOrganizationName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name of the person
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The name of the organization
        /// </summary>
        [JsonProperty("organizationName")]
        public string OrganizationName
        {
            get => mOrganizationName ?? string.Empty;
            set => mOrganizationName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailOrganizationNameResponseModel() : base()
        {

        }

        #endregion
    }
}