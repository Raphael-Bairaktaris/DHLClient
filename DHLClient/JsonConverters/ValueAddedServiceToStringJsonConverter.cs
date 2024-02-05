// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="ValueAddedService"/> to <see cref="string"/>
    /// </summary>
    public class ValueAddedServiceToStringJsonConverter : BaseEnumJsonConverter<ValueAddedService>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ValueAddedServiceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ValueAddedService, string> GetMapper() => DHLClientConstants.ValueAddedServiceToStringMapper;

        #endregion
    }
}
