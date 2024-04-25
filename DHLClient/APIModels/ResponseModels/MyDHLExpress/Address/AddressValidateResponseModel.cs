using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an address validation 
    /// </summary>
    public class AddressValidateResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private IEnumerable<AddressDetailResponseModel>? mAddress;

        #endregion

        #region Public Properties

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string> Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        /// <summary>
        /// The address
        /// </summary>
        [JsonProperty("address")]
        public IEnumerable<AddressDetailResponseModel> Address
        {
            get => mAddress ?? Enumerable.Empty<AddressDetailResponseModel>();
            set => mAddress = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressValidateResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Warnings: {Warnings}";

        #endregion
    }
}
