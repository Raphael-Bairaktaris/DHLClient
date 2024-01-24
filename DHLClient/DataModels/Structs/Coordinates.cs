namespace DHLClient
{
    /// <summary>
    /// A set of coordinates.
    /// </summary>
    public readonly record struct Coordinates : IAPIStringFormattable
    {
        #region Public Properties

        /// <summary>
        /// The latitude
        /// </summary>
        public double Latitude { get; }

        /// <summary>
        /// The longitude
        /// </summary>
        public double Longitude { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="latitude"> The latitude </param>
        /// <param name="longitude"> The longitude </param>
        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";

        /// <inheritdoc/>
        public string ToAPIString() => $"{Latitude.ToString().Replace(",", ".")},{Longitude.ToString().Replace(",", ".")}";

        #endregion
    }
}
