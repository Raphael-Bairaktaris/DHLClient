using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an identifier response
    /// </summary>
    public class IdentifierResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string>? Warnings { get; set; }

        /// <summary>
        /// The identifiers
        /// </summary>
        public IdentifiersResponseModel Identifiers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifierResponseModel() : base()
        {

        }

        #endregion
    }
}
