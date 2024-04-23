using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all the shippers
    /// </summary>
    public class ShippingEntityResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref=""/>
        /// </summary>
        private PostalAddressResponseModel? mPostalAddress;

        /// <summary>
        /// The member of the <see cref="ContactInformation"/> property
        /// </summary>
        private ContactInformationResponseModel? mContactInformation;

        #endregion

        #region Public Properties

        /// <summary>
        /// The postal address details
        /// </summary>
        [JsonProperty("postalAddress")]
        public PostalAddressResponseModel PostalAddress
        {
            get => mPostalAddress ??= new PostalAddressResponseModel();
            set => mPostalAddress = value;
        }

        /// <summary>
        /// The contact information details
        /// </summary>
        [JsonProperty("contactInformation")]
        public ContactInformationResponseModel ContactInformation
        {
            get => mContactInformation ??= new ContactInformationResponseModel();
            set => mContactInformation = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShippingEntityResponseModel() : base()
        {

        }

        #endregion
    }
}