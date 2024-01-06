namespace DHLClient
{
    /// <summary>
    /// Provides argument name meta data to an item
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ArgumentNameAttribute : Attribute
    {
        #region Public Properties

        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">The name</param>
        public ArgumentNameAttribute(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            Name = name;
        }

        #endregion
    }
}
