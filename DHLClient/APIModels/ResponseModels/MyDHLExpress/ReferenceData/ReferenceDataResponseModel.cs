using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a reference data
    /// </summary>
    public class ReferenceDataResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ReferenceData"/> property
        /// </summary>
        private IEnumerable<ReferenceDataDetailResponseModel>? mReferenceData;

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// The result of search from provided reference criteria
        /// </summary>
        public IEnumerable<ReferenceDataDetailResponseModel> ReferenceData
        {
            get => mReferenceData ?? Enumerable.Empty<ReferenceDataDetailResponseModel>();
            set => mReferenceData = value;
        }

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReferenceDataResponseModel() : base()
        {

        }

        #endregion
    }
}
