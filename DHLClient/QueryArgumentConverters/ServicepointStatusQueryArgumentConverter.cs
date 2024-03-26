namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="ServicepointStatus"/> to <see cref="string"/>
    /// </summary>
    public class ServicepointStatusQueryArgumentConverter : BaseQueryArgumentConverter<ServicepointStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicepointStatusQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(ServicepointStatus value) => DHLClientConstants.ServicePointStatusToStringMapper[value];

        #endregion
    }
}
