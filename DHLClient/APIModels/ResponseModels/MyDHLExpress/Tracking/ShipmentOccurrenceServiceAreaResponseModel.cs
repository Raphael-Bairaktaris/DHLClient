using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a shipment occurrence service area response
    /// </summary>
    public class ShipmentOccurrenceServiceAreaResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Code"/> property
        /// </summary>
        private string? mCode;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        #endregion

        #region Public Properties

        /// <summary>
        /// The service area code
        /// </summary>
        /// <example>BNE</example>
        [JsonProperty("code")]
        public string Code
        {
            get => mCode ?? string.Empty;
            set => mCode = value;
        }

        /// <summary>
        /// The service area description
        /// </summary>
        /// <example>Brisbane-AU</example>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentOccurrenceServiceAreaResponseModel() : base()
        {

        }

        #endregion
    }
}