﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents a shipment proof of delivery document response
    /// </summary>
    public class ShipmentProofOfDeliveryDocumentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Content"/> property
        /// </summary>
        private string? mContent;

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The encoding format
        /// </summary>
        /// <example>PDF</example>
        [JsonProperty("encodingFormat")]
        public EncodingFormat EncodingFormat { get; set; }

        /// <summary>
        /// The content
        /// </summary>
        /// <example>base64 encoded content</example>
        [JsonProperty("content")]
        public string Content
        {
            get => mContent ?? string.Empty;
            set => mContent = value;
        }

        /// <summary>
        /// The type code
        /// </summary>
        /// <example>POD</example>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentProofOfDeliveryDocumentResponseModel() : base()
        {

        }

        #endregion
    }
}
