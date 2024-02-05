// Ignore Spelling: Incoterm Measurment

namespace DHLClient
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="TrackingView"/> to <see cref="string"/>
    /// </summary>
    public class TrackingViewToStringJsonConverter : BaseEnumJsonConverter<TrackingView>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackingViewToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TrackingView, string> GetMapper() => DHLClientConstants.TrackingViewToStringMapper;

        #endregion
    }
}
