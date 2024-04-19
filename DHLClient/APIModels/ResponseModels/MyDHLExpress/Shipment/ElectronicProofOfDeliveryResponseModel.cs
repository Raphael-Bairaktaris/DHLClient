using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment proof of delivery document response
    /// </summary>
    public class ElectronicProofOfDeliveryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Documents"/> property
        /// </summary>
        private IEnumerable<ElectronicProofOfDeliveryDetailResponseModel>? mDocuments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The document details
        /// </summary>
        [JsonProperty("documents")]
        public IEnumerable<ElectronicProofOfDeliveryDetailResponseModel> Documents 
        { 
            get => mDocuments ?? Enumerable.Empty<ElectronicProofOfDeliveryDetailResponseModel>();
            set => mDocuments = value;
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ElectronicProofOfDeliveryResponseModel() : base()
        {

        }

        #endregion
    }
}
