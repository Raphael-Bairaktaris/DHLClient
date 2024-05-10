namespace DHLClient.QueryArgumentConverters
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert an <see cref="EncodingFormat"/> to <see cref="string"/>
    /// </summary>
    public class EncodingFormatQueryArgumentConverter : BaseQueryArgumentConverter<EncodingFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EncodingFormatQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(EncodingFormat value) => DHLClientConstants.EncodingFormatToUpperStringMapper[value];

        #endregion
    }
}
