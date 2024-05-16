using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a detail company response
    /// </summary>
    public class ShipmentDetailPersonResponseModel
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
        /// Family name, the last name of a person
        /// </summary>
        [JsonProperty("familyName")]
        public string FamilyName
        {
            get => mFamilyName ?? string.Empty;
            set => mFamilyName = value;
        }

        /// <summary>
        /// Given name, the first name of a person
        /// </summary>
        [JsonProperty("givenName")]
        public string GivenName
        {
            get => mGivenName ?? string.Empty;
            set => mGivenName = value;
        }

        /// <summary>
        /// The name of the person
        /// </summary>
        /// <example>Dariel Leola</example>
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
        public ShipmentDetailPersonResponseModel() : base()
        {

        }

        #endregion
    }
}