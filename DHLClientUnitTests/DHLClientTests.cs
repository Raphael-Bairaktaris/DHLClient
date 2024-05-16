using System.Reflection;

namespace DHLClientTests
{
    /// <summary>
    /// The tests for the <see cref="DHLClient"/>
    /// </summary>
    public class DHLClientTests
    {
        #region Private Members

        /// <summary>
        /// The client
        /// </summary>
        //private readonly DHLClient.DHLLocationFinder mClient;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DHLClientTests() : base()
        {
            var assemblyPath = Assembly.GetExecutingAssembly().Location;

            var parts = assemblyPath.Split('\\');

            var testProjectPath = Path.Combine(parts.Take(parts.Count() - 4).ToArray());

            var credentialsFilePath = Path.Combine(testProjectPath, "DHLCredentials.txt");

            var apiKey = File.ReadAllText(credentialsFilePath);

            //mClient = new DHLClient.DHLLocationFinderClient(apiKey);
        }

        #endregion
    }
}
