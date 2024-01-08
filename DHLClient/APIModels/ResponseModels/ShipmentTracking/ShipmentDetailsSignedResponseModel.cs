using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details signed response
    /// </summary>
    public class ShipmentDetailsSignedResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="FamilyName"/> property
        /// </summary>
        private string? mFamilyName;

        /// <summary>
        /// The member of the <see cref="GivenName"/> property
        /// </summary>
        private string? mGivenName;

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The family name
        /// </summary>
        [JsonProperty("familyName")]
        public string FamilyName
        {
            get => mFamilyName ?? string.Empty;
            set => mFamilyName = value;
        }

        /// <summary>
        /// The given name
        /// </summary>
        [JsonProperty("givenName")]
        public string GivenName
        {
            get => mGivenName ?? string.Empty;
            set => mGivenName = value;
        }

        /// <summary>
        /// The name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsSignedResponseModel() : base()
        {

        }

        #endregion
    }
}