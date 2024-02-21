﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// A <see cref="QueryArgumentConverterAttribute{T}"/> that is used to convert a <see cref="DistanceUnit"/> to <see cref="string"/>
    /// </summary>
    public class DistanceUnitQueryArgumentConverter : BaseQueryArgumentConverter<DistanceUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DistanceUnitQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(DistanceUnit value) => DHLClientConstants.DistanceUnitToStringMapper[value];

        #endregion
    }
}
