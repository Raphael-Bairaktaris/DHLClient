// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="TotalChargeType"/> to <see cref="string"/>
    /// </summary>
    public class TotalChargeTypeToStringJsonConverter : BaseEnumJsonConverter<TotalChargeType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TotalChargeTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TotalChargeType, string> GetMapper() => DHLClientConstants.TotalChargeTypeToStringMapper;

        #endregion
    }
}
