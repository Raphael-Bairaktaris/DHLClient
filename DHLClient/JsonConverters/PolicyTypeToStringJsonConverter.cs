﻿namespace DHLClient
{
    /// <summary>
    /// The <see cref="BaseEnumJsonConverter{T}"/> that converts <see cref="PolicyType"/> to <see cref="string"/>
    /// </summary>
    public class PolicyTypeToStringJsonConverter : BaseEnumJsonConverter<PolicyType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PolicyTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PolicyType, string> GetMapper() => DHLClientConstants.PolicyTypeToStringMapper;

        #endregion
    }
}
