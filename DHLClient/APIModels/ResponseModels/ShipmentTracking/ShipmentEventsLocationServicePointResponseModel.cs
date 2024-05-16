using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a location service point response
    /// </summary>
    public class ShipmentEventsLocationServicePointResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Label"/> property
        /// </summary>
        private string? mLabel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service point url
        /// </summary>
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        /// <summary>
        /// The service point label
        /// </summary>
        [JsonProperty("label")]
        public string Label
        {
            get => mLabel ?? string.Empty;
            set => mLabel = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentEventsLocationServicePointResponseModel() : base()
        {

        }

        #endregion
    }
}