using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a package
    /// </summary>
    public class RatingLandedCostPackageRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Please contact your DHL Express representative if you wish to use a DHL specific package otherwise ignore this element.
        /// </summary>
        [JsonProperty("typeCode")]
        [JsonConverter(typeof(PackagingTypeToStringJsonConverter))]
        public PackagingType? TypeCode { get; set; }

        /// <summary>
        /// The weight of the package.
        /// </summary>
        [JsonRequired]
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Dimensions of the package
        /// </summary>
        [JsonRequired]
        [JsonProperty("dimensions")]
        public RatingLandedCostPackageDimensionRequestModel? Dimensions { get; set; }  

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RatingLandedCostPackageRequestModel() : base()
        {

        }

        #endregion
    }
}