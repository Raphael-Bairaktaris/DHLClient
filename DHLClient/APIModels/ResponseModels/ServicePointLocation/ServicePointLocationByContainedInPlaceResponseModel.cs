using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a description of the building/facility the service point is located in
    /// </summary>
    /// <example> Lidl Markt </example>
    public class ServicePointLocationByContainedInPlaceResponseModel
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
        public ServicePointLocationByContainedInPlaceResponseModel() : base()
        {

        }

        #endregion
    }
}
