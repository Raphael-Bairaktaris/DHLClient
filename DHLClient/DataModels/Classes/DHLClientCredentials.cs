namespace DHLClient
{
    /// <summary>
    /// The DHL Client credentials
    /// </summary>
    public record DHLClientCredentials
    {
        #region Public Properties

        /// <summary>
        /// The username
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        public DHLClientCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        #endregion

    }
}
