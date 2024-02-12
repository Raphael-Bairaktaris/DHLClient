using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used to convert a <see cref="CurrencyType"/> to <see cref="string"/>
    /// </summary>
    public class CurrencyTypeToStringJsonConverter : BaseEnumJsonConverter<CurrencyType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CurrencyType, string> GetMapper() => DHLClientConstants.CurrencyTypeToStringMapper;

        #endregion
    }
}
