﻿using Newtonsoft.Json;

namespace DHLClient.MyDHLExpress
{
    /// <summary>
    /// Represents an identifier 
    /// </summary>
    public class IdentifierResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        /// <summary>
        /// The member of the <see cref="Identifiers"/> property
        /// </summary>
        private IEnumerable<IdentifierDetailResponseModel>? mIdentifiers;

        #endregion

        #region Public Properties

        /// <summary>
        /// The warnings
        /// </summary>
        [JsonProperty("warnings")]
        public IEnumerable<string>? Warnings
        {
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        /// <summary>
        /// The identifiers
        /// </summary>
        [JsonProperty("identifiers")]
        public IEnumerable<IdentifierDetailResponseModel> Identifiers
        {
            get => mIdentifiers ?? Enumerable.Empty<IdentifierDetailResponseModel>();
            set => mIdentifiers = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IdentifierResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Warnings: {Warnings}";

        #endregion
    }
}
