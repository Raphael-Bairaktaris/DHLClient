namespace DHLClient
{
    /// <summary>
    /// The DHL Client credentials
    /// </summary>
    public record DHLClientCredentials
    {
        #region Public Properties

        /// <summary>
        /// The API key
        /// </summary>
        public string APIKey { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiKey">The API key</param>
        /// <param name="apiURL">The API url</param>
        public DHLClientCredentials(string apiKey)
        {
            APIKey = apiKey ?? string.Empty;
        }

        #endregion

    }
}
