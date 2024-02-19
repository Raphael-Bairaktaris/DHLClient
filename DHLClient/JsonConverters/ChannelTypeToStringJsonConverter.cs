using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="ChannelType"/> to <see cref="string"/>
    /// </summary>
    public class ChannelTypeToStringJsonConverter : BaseEnumJsonConverter<ChannelType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChannelTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ChannelType, string> GetMapper() => DHLClientConstants.ChannelTypeToStringMapper;

        #endregion
    }
}
