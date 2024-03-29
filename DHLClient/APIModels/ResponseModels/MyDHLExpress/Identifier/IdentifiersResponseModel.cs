﻿using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// Represents an identifier response
    /// </summary>
    public class IdentifiersResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TypeCode"/> property
        /// </summary>
        private string? mTypeCode;

        /// <summary>
        /// The member of the <see cref="List"/> property
        /// </summary>
        private IEnumerable<string>? mList;

        #endregion

        #region Public Properties

        /// <summary>
        /// The type of identifier
        /// </summary>
        [JsonProperty("typeCode")]
        public string TypeCode
        {
            get => mTypeCode ?? string.Empty;
            set => mTypeCode = value;
        }

        /// <summary>
        /// List of identifiers
        /// </summary>
        [JsonProperty("list")]
        public IEnumerable<string> List
        {
            get => mList ?? Enumerable.Empty<string>();
            set => mList = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifiersResponseModel() : base()
        {

        }

        #endregion
    }
}