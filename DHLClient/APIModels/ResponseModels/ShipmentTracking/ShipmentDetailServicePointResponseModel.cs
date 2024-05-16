using Newtonsoft.Json;

namespace DHLClient.ShipmentTracking
{
    /// <summary>
    /// Represents a shipment service point response
    /// </summary>
    public class ShipmentDetailServicePointResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Label"/> property
        /// </summary>
        private string? mLabel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri? URL { get; set; }

        /// <summary>
        /// The label
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
        public ShipmentDetailServicePointResponseModel() : base()
        {

        }

        #endregion
    }
}