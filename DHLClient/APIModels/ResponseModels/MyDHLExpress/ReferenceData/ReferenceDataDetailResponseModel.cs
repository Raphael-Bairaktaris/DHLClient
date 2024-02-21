using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a reference data detail response
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
        /// TODO
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }

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