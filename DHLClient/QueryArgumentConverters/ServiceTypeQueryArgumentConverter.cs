namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{Tvalue}"/> that is used for converting a <see cref="ServiceType"/> to a <see cref="string"/> 
    /// </summary>
    public class ServiceTypeQueryArgumentConverter : BaseQueryArgumentConverter<ServiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceTypeQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods


        /// <inheritdoc/>
        public override string Convert(ServiceType value) => DHLClientConstants.ServiceTypeToStringMapper[value];

        #endregion
    }
}
