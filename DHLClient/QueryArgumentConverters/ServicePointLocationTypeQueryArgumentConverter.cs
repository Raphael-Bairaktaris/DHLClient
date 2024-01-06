namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="ServicePointLocationType"/> to a <see cref="string"/> 
    /// </summary>
    public class ServicePointLocationTypeQueryArgumentConverter : BaseQueryArgumentConverter<ServicePointLocationType>
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationTypeQueryArgumentConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ServicePointLocationType value) => DHLClientConstants.ServicePointLocationTypeToStringMapper[value];

        #endregion
    }
}
