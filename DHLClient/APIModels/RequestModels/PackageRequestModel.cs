using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a package
    /// </summary>
    public class PackageRequestModel : ShipmentDetailsDimensionsResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Please contact your DHL Express representative if you wish to use a DHL specific package otherwise ignore this element.
        /// </summary>
        [JsonProperty("typeCode")]
        public PackagingType TypeCode { get; set; }

        /// <summary>
        /// The weight of the package.
        /// </summary>
        [JsonRequired]
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PackageRequestModel() : base()
        {

        }

        #endregion
    }
}