using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all the customer reference request models
    /// </summary>
    /// <typeparam name="T">The type of the code</typeparam>
    public abstract class BaseCustomerReferenceRequestModel<T>
        where T : struct, Enum
    {
        #region Public Properties

        /// <summary>
        /// Please provide the line item reference type code.
        /// </summary>
        public abstract T? TypeCode { get; set; }

        /// <summary>
        /// Please provide the line item reference
        /// </summary>
        [JsonRequired]
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseCustomerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}