using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment image
    /// </summary>
    public class ShipmentImageResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Documents"/> property
        /// </summary>
        private IEnumerable<ShipmentImageDocumentResponseModel>? mDocuments;

        #endregion

        #region Public Properties

        /// <summary>
        /// Here you can find all document images from search query
        /// </summary>
        [JsonProperty("documents")]
        public IEnumerable<ShipmentImageDocumentResponseModel> Documents 
        { 
            get => mDocuments ?? Enumerable.Empty<ShipmentImageDocumentResponseModel>();
            set => mDocuments = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentImageResponseModel() : base()
        {

        }

        #endregion
    }
}
