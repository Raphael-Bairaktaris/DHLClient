namespace DHLClient
{
    /// <summary>
    /// The base for all my DHL API arguments
    /// </summary>
    public class BaseMyDHLAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Please provide message reference
        /// </summary>
        [ArgumentName("Message-Reference")]
        public string? MessageReference { get; set; }

        /// <summary>
        /// Optional reference date in the HTTP-date format
        /// </summary>
        /// <remarks>https://tools.ietf.org/html/rfc7231#section-7.1.1.2</remarks>
        [ArgumentName("Message-Reference-Date")]
        public DateTimeOffset? MessageReferenceDate { get; set; }

        /// <summary>
        /// Please provide name of the plugin (applicable to 3PV only)
        /// </summary>
        [ArgumentName("Plugin-Name")]
        public string? PluginName { get; set; }

        /// <summary>
        /// Please provide version of the plugin (applicable to 3PV only)
        /// </summary>
        [ArgumentName("Plugin-Version")]
        public string? PluginVersion { get; set; }

        /// <summary>
        /// Please provide name of the shipping platform(applicable to 3PV only)
        /// </summary>
        [ArgumentName("Shipping-System-Platform-Name")]
        public string? ShippingSystemPlatformName { get; set; }

        /// <summary>
        /// Please provide version of the shipping platform (applicable to 3PV only)
        /// </summary>
        [ArgumentName("Shipping-System-Platform-Version")]
        public string? ShippingSystemPlatformVersion { get; set; }

        /// <summary>
        /// Please provide name of the webstore platform (applicable to 3PV only)
        /// </summary>
        [ArgumentName("Webstore-Platform-Name")]
        public string? WebstorePlatformName { get; set; }

        /// <summary>
        /// Please provide version of the webstore platform (applicable to 3PV only)
        /// </summary>
        [ArgumentName("Webstore-Platform-Version")]
        public string? WebstorePlatformVersion { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseMyDHLAPIArgs() : base()
        {

        }

        #endregion
    }
}
