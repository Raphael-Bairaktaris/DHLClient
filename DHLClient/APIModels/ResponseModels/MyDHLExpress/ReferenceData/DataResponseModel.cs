using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents data
    /// </summary>
    public class DataResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Attribute"/> property
        /// </summary>
        private string? mAttribute;

        /// <summary>
        /// The member of the <see cref="Value"/> property
        /// </summary>
        private string? mValue;

        #endregion

        #region Public Properties

        /// <summary>
        /// The attribute
        /// </summary>
        [JsonProperty("attribute")]
        public string Attribute
        {
            get => mAttribute ?? string.Empty;
            set => mAttribute = value;
        }

        /// <summary>
        /// The value
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get => mValue ?? string.Empty;
            set => mValue = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DataResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Attribute: {Attribute}, Value: {Value}";

        #endregion
    }
}