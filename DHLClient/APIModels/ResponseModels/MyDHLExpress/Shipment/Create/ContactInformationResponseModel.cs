using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents contact information
    /// </summary>
    public class ContactInformationResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="CompanyName"/> property
        /// </summary>
        private string? mCompanyName;

        /// <summary>
        /// The member of the <see cref="FullName"/> property
        /// </summary>
        private string? mFullName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The company name
        /// </summary>
        /// <example>Better One  s.r.c</example>
        [JsonProperty("companyName")]
        public string CompanyName
        {
            get => mCompanyName ?? string.Empty;
            set => mCompanyName = value;
        }

        /// <summary>
        /// The full name
        /// </summary>
        /// <example>Huahom Peral</example>
        [JsonProperty("fullName")]
        public string FullName
        {
            get => mFullName ?? string.Empty;
            set => mFullName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactInformationResponseModel() : base()
        {

        }

        #endregion
    }
}