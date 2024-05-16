using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents a base required service code response
    /// </summary>
    public class BaseRequiredServiceCodeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceCode"/> property
        /// </summary>
        private string? mServiceCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The special service charge code
        /// </summary>
        /// <example>PZ</example>
        [JsonProperty("serviceCode")]
        public string ServiceCode
        {
            get => mServiceCode ?? string.Empty;
            set => mServiceCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseRequiredServiceCodeResponseModel() : base()
        {

        }

        #endregion
    }
}