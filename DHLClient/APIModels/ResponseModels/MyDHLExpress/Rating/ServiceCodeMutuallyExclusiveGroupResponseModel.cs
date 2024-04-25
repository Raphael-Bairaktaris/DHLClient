using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a service code mutually exclusive group response
    /// </summary>
    public class ServiceCodeMutuallyExclusiveGroupResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ServiceCodeRuleName"/> property
        /// </summary>
        private string? mServiceCodeRuleName;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="ServiceCodes"/> property
        /// </summary>
        private IEnumerable<BaseRequiredServiceCodeResponseModel>? mServiceCodes;

        #endregion

        #region Public Properties

        /// <summary>
        /// Mutually exclusive serviceCode group name
        /// </summary>
        /// <example>Exclusive Billing Services</example>
        [JsonProperty("serviceCodeRuleName")]
        public string ServiceCodeRuleName
        {
            get => mServiceCodeRuleName ?? string.Empty;
            set => mServiceCodeRuleName = value;
        }

        /// <summary>
        /// Mutually exclusive serviceCode group description
        /// </summary>
        /// <example>Mutually exclusive Billing Services - shipment can contain just one of following</example>
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The service codes
        /// </summary>
        [JsonProperty("serviceCodes")]
        public IEnumerable<BaseRequiredServiceCodeResponseModel> ServiceCodes
        {
            get => mServiceCodes ?? Enumerable.Empty<BaseRequiredServiceCodeResponseModel>();
            set => mServiceCodes = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceCodeMutuallyExclusiveGroupResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Service Code Rule Name: {ServiceCodeRuleName}, Description: {Description}";

        #endregion
    }
}