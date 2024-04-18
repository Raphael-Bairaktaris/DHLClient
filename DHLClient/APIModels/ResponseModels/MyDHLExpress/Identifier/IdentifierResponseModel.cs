using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an identifier response
    /// </summary>
    public class IdentifierResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        /// <summary>
        /// The member of the <see cref="Identifiers"/> property
        /// </summary>
        private IEnumerable<IdentifiersResponseModel>? mIdentifiers;

        #endregion

        #region Public Properties

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string>? Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        /// <summary>
        /// The identifiers
        /// </summary>
        [JsonProperty("identifiers")]
        public IEnumerable<IdentifiersResponseModel> Identifiers
        {
            get => mIdentifiers ?? Enumerable.Empty<IdentifiersResponseModel>();
            set => mIdentifiers = value;
        }

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
