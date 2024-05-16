namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents location coordinates
    /// </summary>
    public class SearchLocationCoordinatesResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The coordinates
        /// </summary>
        public Coordinates Coordinates { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SearchLocationCoordinatesResponseModel() : base()
        {

        }

        #endregion
    }
}