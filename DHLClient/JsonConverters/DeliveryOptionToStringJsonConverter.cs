﻿namespace DHLClient
{
    /// <summary>
    /// A <see cref="BaseEnumJsonConverter{T}"/> that converts a <see cref="DeliveryOption"/> to <see cref="string"/>
    /// </summary>
    public class DeliveryOptionToStringJsonConverter : BaseEnumJsonConverter<DeliveryOption>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeliveryOptionToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<DeliveryOption, string> GetMapper() => DHLClientConstants.DeliveryOptionToStringMapper;

        #endregion
    }
}
