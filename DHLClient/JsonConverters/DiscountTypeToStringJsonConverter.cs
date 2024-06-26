﻿namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DiscountType"/> to <see cref="string"/>
    /// </summary>
    public class DiscountTypeToStringJsonConverter : BaseEnumJsonConverter<DiscountType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DiscountTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DiscountType, string> GetMapper() => DHLClientConstants.DiscountTypeToStringMapper;

        #endregion
    }
}
