using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating special instructions
    /// </summary>
    public class SpecialInstructionRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Any special instructions user wish to send to the courier for the order pick-up.
        /// </summary>
        /// <example>please ring doorbell</example>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// For future use
        /// </summary>
        [JsonProperty("typeCode")]
        public string? TypeCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SpecialInstructionRequestModel() : base()
        {

        }

        #endregion
    }
}