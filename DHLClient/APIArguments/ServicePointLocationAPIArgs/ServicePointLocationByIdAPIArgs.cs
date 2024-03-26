using System.Text.Json.Serialization;

namespace DHLClient
{
    /// <summary>
    /// The arguments used for receiving a DHL service point location by id
    /// </summary>
    public class ServicePointLocationByIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// ID of the DHL Service Point location.
        /// </summary>
        [JsonRequired]
        [ArgumentName("id")]
        public string? LocationId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServicePointLocationByIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
