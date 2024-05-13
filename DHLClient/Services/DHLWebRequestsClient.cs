using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="WebRequestResult"/> configured for sending requests to the DHL API
    /// </summary>
    public class DHLWebRequestsClient : WebRequestsClient<DHLClientCredentials>
    {
        #region Public Properties

        /// <summary>
        /// The single instance of the <see cref="DHLWebRequestsClient"/>
        /// </summary>
        public static DHLWebRequestsClient Instance { get; } = new();

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        protected DHLWebRequestsClient() : base()
        {
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override void ConfigureClientBeforeSendingRequest(HttpClient client)
        {
            base.ConfigureClientBeforeSendingRequest(client);

            Client.DefaultRequestHeaders.Add("Message-Reference", Guid.NewGuid().ToString());
            Client.DefaultRequestHeaders.Add("Message-Reference-Date", DateTimeOffset.UtcNow.ToString("ddd, dd MMM yyyy HH:mm:ss", CultureInfo.InvariantCulture) + " GMT");
        }

        /// <inheritdoc/>
        protected override void ConfigureStringContent(StringContent stringContent)
        {
            base.ConfigureStringContent(stringContent);

            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        /// <inheritdoc/>
        protected override AuthenticationHeaderValue CreateAuthenticationHeader(DHLClientCredentials authenticationArgs)
        {
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(authenticationArgs.Username + ":" + authenticationArgs.Password));

            return new AuthenticationHeaderValue("Basic", svcCredentials);
        }

        #endregion
    }
}
