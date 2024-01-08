using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment details participant response
    /// </summary>
    public class ShipmentDetailsParticipantResponseModel : ShipmentDetailsSignedResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="OrganizationName"/> property
        /// </summary>
        private string? mOrganizationName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The organization name
        /// </summary>
        [JsonProperty("organizationName")]
        public string OrganizationName 
        { 
            get => mOrganizationName ?? string.Empty;
            set => mOrganizationName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentDetailsParticipantResponseModel() : base()
        {

        }

        #endregion
    }
}
