using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="BarcodePositionType"/> to <see cref="string"/>
    /// </summary>
    public class BarcodePositionTypeToStringJsonConverter : BaseEnumJsonConverter<BarcodePositionType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BarcodePositionTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Method

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BarcodePositionType, string> GetMapper() => DHLClientConstants.BarcodePositionTypeToStringMapper;

        #endregion
    }
}
