using DHLClient.DataModels.Enums;

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="IEnumerable{DestinationProvider}"/> to <see cref="string"/>
    /// </summary>
    public class DestinationProviderToStringJsonConverter : BaseEnumJsonConverter<DestinationProvider>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DestinationProviderToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DestinationProvider, string> GetMapper() => DHLClientConstants.DestinationProviderToStringMapper;

        #endregion
    }
}
