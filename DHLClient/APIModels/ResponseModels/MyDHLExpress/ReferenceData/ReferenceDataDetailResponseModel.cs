using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a reference data detail
    /// </summary>
    public class ReferenceDataDetailResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="DataSetName"/> property
        /// </summary>
        private string? mDatasetName;

        /// <summary>
        /// The member of the <see cref="DataSetCaptions"/> property
        /// </summary>
        private string? mDataSetCaptions;

        /// <summary>
        /// The member of the <see cref="Data"/> property
        /// </summary>
        private IEnumerable<IEnumerable<DataResponseModel>>? mData;

        #endregion

        #region Public Properties

        /// <summary>
        /// The reference data dataset name
        /// </summary>
        /// <example>country</example>
        [JsonProperty("datasetName")]
        public string DataSetName
        {
            get => mDatasetName ?? string.Empty;
            set => mDatasetName = value;
        }

        /// <summary>
        /// The data set captions
        /// </summary>
        [JsonProperty("dataSetCaptions")]
        public string DataSetCaptions
        {
            get => mDataSetCaptions ?? string.Empty;
            set => mDataSetCaptions = value;
        }

        /// <summary>
        /// The data
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<IEnumerable<DataResponseModel>> Data
        {
            get => mData ?? Enumerable.Empty<IEnumerable<DataResponseModel>>();
            set => mData = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReferenceDataDetailResponseModel() : base()
        {

        }

        #endregion
    }
}