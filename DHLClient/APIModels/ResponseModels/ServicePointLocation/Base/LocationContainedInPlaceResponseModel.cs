using Newtonsoft.Json;

namespace DHLClient.LocationUnified
{
    /// <summary>
    /// Represents a description of the building/facility the service point is located in
    /// </summary>
    public class LocationContainedInPlaceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name of the facility
        /// </summary>
        /// <example>Lidl Markt</example>
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
        public LocationContainedInPlaceResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Name: {Name}";

        #endregion
    }
}
