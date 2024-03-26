namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="Coordinates"/> to <see cref="string"/>
    /// </summary>
    public class CoordinatesQueryArgumentConverter : BaseQueryArgumentConverter<Coordinates>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CoordinatesQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(Coordinates value) => value.ToString();

        #endregion
    }
}
