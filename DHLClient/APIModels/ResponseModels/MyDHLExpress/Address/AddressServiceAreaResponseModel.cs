using DHLClient.JsonConverters;
using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an address service area
    /// </summary>
    public class AddressServiceAreaResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Code"/> property
        /// </summary>
        private string? mCode;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service area code
        /// </summary>
        /// <example>BSA</example>
        [JsonProperty("code")]
        public string Code
        {
            get => mCode ?? string.Empty;
            set => mCode = value;
        }

        /// <summary>
        /// The service area description 
        /// </summary>
        /// <example>BSA area</example>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The time offset
        /// </summary>
        /// <example>+01:00</example>
        [JsonProperty("GMTOffset")]
        [JsonConverter(typeof(TimeSpanToGMTOffsetStringJsonConverter))]
        public TimeSpan? GMTOffset { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressServiceAreaResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Code: {Code}, Description: {Description}";

        #endregion
    }
}