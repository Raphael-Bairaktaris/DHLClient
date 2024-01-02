
namespace DHLClient
{
    /// <summary>
    /// Represent a find location response
    /// </summary>
    public class FindLocationResponseModel
    {
        #region Private Members


        #endregion

        #region Public Properties

        /// <summary>
        /// One location can be known within different business units (providerTypes). They will be known under a unique ID within each business unit domain, as provided.
        /// </summary>
        public IEnumerable<IdResponseModel> Ids { get; set; }

        /// <summary>
        /// The ID as how the location is know within this business unit / provider.
        /// </summary>
        /// <example>
        /// 8003-4103535
        /// </example>
        public string LocationId { get; set; }

        /// <summary>
        /// The business unit of the DHL Service Point location.
        /// </summary>
        /// <example> parcel </example>
        public string Provider { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public FindLocationResponseModel() : base()
        {

        }

        #endregion
    }
}
