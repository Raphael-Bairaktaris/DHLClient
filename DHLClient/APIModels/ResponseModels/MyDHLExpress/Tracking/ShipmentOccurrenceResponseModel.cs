using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment occurrence response
    /// </summary>
    public class ShipmentOccurrenceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        /// <summary>
        /// the member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="ServiceArea"/> property
        /// </summary>
        private ShipmentOccurrenceServiceAreaResponseModel? mServiceArea;

        /// <summary>
        /// The member of the <see cref="SignedBy"/> property
        /// </summary>
        private string? mSignedBy;

        #endregion

        #region Public Properties

        /// <summary>
        /// The occurrence date 
        /// </summary>
        /// <example>2020-06-10</example>
        [JsonProperty("date")]
        public DateOnly Date { get; set; }

        /// <summary>
        /// The occurrence rime
        /// </summary>
        /// <example>13:06:00</example>
        [JsonProperty("time")]
        public TimeOnly Time { get; set; }

        /// <summary>
        /// The occurrence type code
        /// </summary>
        /// <example>PU</example>
        [JsonProperty("typeCode")]
        public string TypeCode 
        { 
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// The occurrence description
        /// </summary>
        /// <example>Shipment picked up</example>
        [JsonProperty("description")]
        public string Description 
        { 
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The occurrence service area
        /// </summary>
        [JsonProperty("serviceArea")]
        public ShipmentOccurrenceServiceAreaResponseModel ServiceArea 
        { 
            get => mServiceArea ??= new ShipmentOccurrenceServiceAreaResponseModel();
            set => mServiceArea = value;
        }

        /// <summary>
        /// The occurrence signed by 
        /// </summary>
        /// <example>Mr. Grey</example>
        [JsonProperty("signedBy")]
        public string SignedBy 
        { 
            get => mSignedBy ?? string.Empty;
            set => mSignedBy = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentOccurrenceResponseModel() : base()
        {

        }

        #endregion
    }
}