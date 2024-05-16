using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a detail company response
    /// </summary>
    public class ShipmentDetailCompanyResponseModel
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
        /// <example>Linford Alene</example>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The name of organization
        /// </summary>
        /// <example>The First Dome Ltd.</example>
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
        public ShipmentDetailCompanyResponseModel() : base()
        {

        }

        #endregion
    }
}