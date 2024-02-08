namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="LocationType"/> to a <see cref="string"/> 
    /// </summary>
    public class LocationTypeQueryArgumentConverter : BaseQueryArgumentConverter<LocationType>
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationTypeQueryArgumentConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(LocationType value) => DHLClientConstants.LocationTypeToStringMapper[value];

        #endregion
    }
}
