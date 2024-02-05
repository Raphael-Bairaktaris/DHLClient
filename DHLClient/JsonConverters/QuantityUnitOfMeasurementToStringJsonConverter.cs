// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="QuantityUnitOfMeasurement"/> to <see cref="string"/>
    /// </summary>
    public class QuantityUnitOfMeasurementToStringJsonConverter : BaseEnumJsonConverter<QuantityUnitOfMeasurement>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuantityUnitOfMeasurementToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<QuantityUnitOfMeasurement, string> GetMapper() => DHLClientConstants.QuantityUnitOfMeasurementToStringMapper;

        #endregion
    }
}
