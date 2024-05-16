using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Requests used for creating or updating a declaration note
    /// </summary>
    public class ShipmentDetailExportDeclarationNoteRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Up to three declaration notes
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailExportDeclarationNoteRequestModel() : base()
        {

        }

        #endregion
    }
}