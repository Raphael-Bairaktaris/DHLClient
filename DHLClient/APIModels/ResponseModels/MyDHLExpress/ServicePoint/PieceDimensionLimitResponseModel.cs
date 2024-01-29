using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The member of the <see cref=""/>
    /// </summary>
    public class PieceDimensionLimitResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The length
        /// </summary>
        [JsonProperty("l")]
        public double Length { get; set; }

        /// <summary>
        /// The weight
        /// </summary>
        [JsonProperty("w")]
        public double Weight { get; set; }

        /// <summary>
        /// The height
        /// </summary>
        [JsonProperty("h")]
        public double Height { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PieceDimensionLimitResponseModel() : base()
        {

        }

        #endregion
    }
}