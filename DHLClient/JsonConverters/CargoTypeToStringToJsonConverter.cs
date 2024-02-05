namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CargoType"/> to <see cref="string"/>
    /// </summary>
    public class CargoTypeToStringToJsonConverter : BaseEnumJsonConverter<CargoType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CargoTypeToStringToJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CargoType, string> GetMapper() => DHLClientConstants.CargoTypeToStringMapper;

        #endregion
    }
}