using System.Text.Json.Serialization;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a package dimension
    /// </summary>
    public class PackageDimensionRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The length of the package
        /// </summary>
        [JsonRequired]
        [JsonPropertyName("length")]
        public double Length { get; set; }

        /// <summary>
        /// The width of the package
        /// </summary>
        [JsonRequired]
        [JsonPropertyName("width")]
        public double Width { get; set; }

        /// <summary>
        /// The height of the package
        /// </summary>
        [JsonRequired]
        [JsonPropertyName("height")]
        public double Height { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PackageDimensionRequestModel() : base()
        {

        }

        #endregion
    }
}