using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a shipment content
    /// </summary>
    public class ShipmentContentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Here you can find all details related to export declaration
        /// </summary>
        [JsonRequired]
        [JsonProperty("exportDeclaration")]
        public IEnumerable<ExportDeclarationDetailRequestModel>? ExportDeclaration { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentContentRequestModel() : base()
        {

        }

        #endregion
    }
}