using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLClient
{
    /// <summary>
    /// Represents a pickup update
    /// </summary>
    public class UpdatePickupResponseModel
    {
        #region private Members

        /// <summary>
        /// The member of the <see cref="DispartConfirmationNumber"/> property
        /// </summary>
        private string? mDispatchConfirmationNumber;

        /// <summary>
        /// The member of the <see cref="Warnings"/> property
        /// </summary>
        private IEnumerable<string>? mWarnings;

        #endregion

        #region Public Properties

        /// <summary>
        /// Identifies the pickup you made the changes for
        /// </summary>
        /// <example>PRG201220123456</example>
        public string DispartConfirmationNumber 
        { 
            get => mDispatchConfirmationNumber ?? string.Empty;
            set => mDispatchConfirmationNumber = value;
        }

        /// <summary>
        /// The ready by time
        /// </summary>
        /// <example>10:00</example>
        public TimeOnly ReadyByTime { get; set; }

        /// <summary>
        /// The next pickup date
        /// </summary>
        /// <example>2020-06-01</example>
        public DateOnly NextPickupDate { get; set; }

        /// <summary>
        /// The warnings
        /// </summary>
        /// <example>Pickup has been updated but something went wrong</example>
        public IEnumerable<string> Warnings 
        { 
            get => mWarnings ?? Enumerable.Empty<string>();
            set => mWarnings = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdatePickupResponseModel() : base()
        {

        }

        #endregion
    }
}
