using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details participant response
    /// </summary>
    public class ShipmentDetailsEntityResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OrganizationName"/> property
        /// </summary>
        private ShipmentDetailOrganizationNameResponseModel? mOrganizationName;

        /// <summary>
        /// The member of the <see cref="OrganizationName"/> property
        /// </summary>
        private ShipmentDetailCompanyResponseModel? mCompany;

        /// <summary>
        /// The member of the <see cref="OrganizationName"/> property
        /// </summary>
        private ShipmentDetailPersonResponseModel? mPerson;

        #endregion

        #region Public Properties

        /// <summary>
        /// Common organization such as school, club etc.
        /// </summary>
        [JsonProperty("organizationName")]
        public ShipmentDetailOrganizationNameResponseModel OrganizationName
        {
            get => mOrganizationName ??= new ShipmentDetailOrganizationNameResponseModel();
            set => mOrganizationName = value;
        }

        /// <summary>
        /// A business organization
        /// </summary>
        [JsonProperty("Company")]
        public ShipmentDetailCompanyResponseModel Company
        {
            get => mCompany ??= new ShipmentDetailCompanyResponseModel();
            set => mCompany = value;
        }

        /// <summary>
        /// A person
        /// </summary>
        [JsonProperty("Person")]
        public ShipmentDetailPersonResponseModel Person
        {
            get => mPerson ??= new ShipmentDetailPersonResponseModel();
            set => mPerson = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsEntityResponseModel() : base()
        {

        }

        #endregion
    }
}