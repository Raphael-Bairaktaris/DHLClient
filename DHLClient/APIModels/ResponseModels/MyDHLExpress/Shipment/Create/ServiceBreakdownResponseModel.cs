using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service breakdown
    /// </summary>
    public class ServiceBreakdownResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name
        /// </summary>
        /// <example>EXPRESS WORDWIDE</example>
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The amount price of DHL product and services
        /// </summary>
        /// <example>147</example>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Special service charge code type for service.
        /// </summary>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceBreakdownResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Name: {Name}";

        #endregion
    }
}