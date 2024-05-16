using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents an identifier 
    /// </summary>
    public class IdentifierDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="List"/> property
        /// </summary>
        private IEnumerable<string>? mList;

        #endregion

        #region Public Properties

        /// <summary>
        /// The type of identifier
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(IdentifierTypeToStringJsonConverter))]
        public IdentifierType IdentifierType { get; set; }

        /// <summary>
        /// List of identifiers
        /// </summary>
        [JsonProperty("list")]
        public IEnumerable<string> List
        {
            get => mList ?? Enumerable.Empty<string>();
            set => mList = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifierDetailResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Identifier Type: {IdentifierType}, List: {List}";

        #endregion
    }
}