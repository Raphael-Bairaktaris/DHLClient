using Microsoft.AspNetCore.WebUtilities;
using System.Collections;
using System.Reflection;

namespace DHLClient
{
    public static class RouteHelpers
    {
        #region Private Members

        /// <summary>
        /// Maps a type to its query arguments
        /// </summary>
        private static readonly Dictionary<Type, List<PropertyQueryArgumentInfo>> mTypeToQueryArgumentsMapper = new();

        #endregion

        #region Public Methods

        /// <summary>
        /// Attaches the parameters that are specified as properties in the <paramref name="args"/>
        /// to the specified <paramref name="url"/>.
        /// NOTE: A custom property name can be set using the <see cref="ArgumentNameAttribute"/>!
        /// </summary>
        /// <param name="url">The URL</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public static string AttachParameters<TArgs>(string url, TArgs? args)
            where TArgs : class
        {
            // If there aren't any arguments...
            if (args is null)
                // Return the URL
                return url;

            // Return the URL
            return AttachParametersCore(url, args, typeof(TArgs));
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Attaches the parameters that are specified as properties in the <paramref name="args"/>
        /// to the specified <paramref name="url"/>.
        /// NOTE: A custom property name can be set using the <see cref="ArgumentNameAttribute"/>!
        /// </summary>
        /// <param name="url">The URL</param>
        /// <param name="args">The arguments</param>
        /// <param name="argumentType">The type of the argument</param>
        /// <returns></returns>
        private static string AttachParametersCore(string url, object args, Type argumentType)
        {
            // If this is the first time the specified arguments are used...
            if (!mTypeToQueryArgumentsMapper.TryGetValue(argumentType, out var argumentInfos))
            {
                // Initialize the collection
                argumentInfos = new List<PropertyQueryArgumentInfo>();

                // For every property...
                foreach (var property in argumentType.GetProperties())
                {
                    // Get the custom attributes
                    var attributes = property.GetCustomAttributes(true);

                    // Get the argument name
                    var argumentName = attributes?.OfType<ArgumentNameAttribute>().FirstOrDefault()?.Name ?? property.Name.ToLower();

                    // Create and add the argument info
                    argumentInfos.Add(new PropertyQueryArgumentInfo(property, argumentName));
                }

                // Map it
                mTypeToQueryArgumentsMapper.Add(argumentType, argumentInfos);
            }

            // For every argument info...
            foreach (var argumentInfo in argumentInfos)
            {
                // Get the value
                var value = argumentInfo.PropertyInfo.GetValue(args);

                // If there isn't a value...
                if (value is null)
                    // Continue
                    continue;

                // If the argument info has a converter...
                if (argumentInfo.Converter is not null)
                {
                    // Use the converter to convert the value
                    url = QueryHelpers.AddQueryString(url, argumentInfo.Name, argumentInfo.Converter.Convert(argumentInfo.PropertyInfo.PropertyType, value));

                    // Continue
                    continue;
                }

                // Get the property type
                var propertyType = GetNonNullableType(argumentInfo.PropertyInfo.PropertyType);

                // If it's an enumerable...
                if (argumentInfo.IsEnumerable)
                {
                    // Get the enumerable
                    var enumerable = new List<object>();

                    // For every enumerable value...
                    foreach (var v in (IEnumerable)value)
                        // Add it to the list
                        enumerable.Add(v);

                    // If there aren't any items
                    if (enumerable.IsNullOrEmpty())
                        // Continue
                        continue;

                    // Set the values
                    url = QueryHelpers.AddQueryString(url, argumentInfo.Name, enumerable.AggregateString(","));

                    // Continue
                    continue;
                }

                // If it's a date...
                if (argumentInfo.IsDate)
                {
                    var isoStringValue = string.Empty;

                    if (propertyType == typeof(DateTime))
                        isoStringValue = ((DateTime)value).ToISO8601String();
                    else if (propertyType == typeof(DateTime?))
                        isoStringValue = ((DateTime?)value).Value.ToISO8601String();
                    else if (propertyType == typeof(DateTimeOffset))
                        isoStringValue = ((DateTimeOffset)value).ToISO8601String();
                    else if (propertyType == typeof(DateTimeOffset?))
                        isoStringValue = ((DateTimeOffset?)value).Value.ToISO8601String();
                    else if (propertyType == typeof(DateOnly))
                        isoStringValue = ((DateOnly)value).ToISO8601String();
                    else if (propertyType == typeof(DateOnly?))
                        isoStringValue = ((DateOnly?)value).Value.ToISO8601String();

                    url = QueryHelpers.AddQueryString(url, argumentInfo.Name, isoStringValue);

                    // Continue
                    continue;
                }

                // If it's a time...
                if (argumentInfo.PropertyInfo.PropertyType == typeof(TimeOnly) || argumentInfo.PropertyInfo.PropertyType == typeof(TimeOnly?))
                {
                    var isoStringValue = string.Empty;

                    if (propertyType == typeof(TimeOnly))
                        isoStringValue = ((TimeOnly)value).ToISO8601String();
                    else if (propertyType == typeof(TimeOnly?))
                        isoStringValue = ((TimeOnly?)value).Value.ToISO8601String();

                    url = QueryHelpers.AddQueryString(url, argumentInfo.Name, isoStringValue);

                    // Continue
                    continue;
                }

                // Get the argument value
                var argumentValue = value?.ToString() ?? string.Empty;

                // If the property type is boolean...
                if (propertyType == typeof(bool))
                    // Lower the first letter of the value
                    argumentValue = argumentValue.FirstCharToLower();

                // If the property type is an enum and there is a value
                if (propertyType.IsEnum && value is not null)
                {
                    url = QueryHelpers.AddQueryString(url, argumentInfo.Name, argumentValue);

                    // Continue
                    continue;
                }

                // Set the value
                url = QueryHelpers.AddQueryString(url, argumentInfo.Name, argumentValue);
            }

            // Return the URL
            return url;
        }

        /// <summary>
        /// Gets the T from the <see cref="Nullable{T}"/> of the specified <paramref name="type"/>
        /// when the <paramref name="type"/> is nullable, otherwise it returns the type
        /// </summary>
        /// <param name="type">The type</param>
        /// <returns></returns>
        private static Type GetNonNullableType(Type type)
            => Nullable.GetUnderlyingType(type) ?? type;

        #endregion

        #region Private Classes

        /// <summary>
        /// The information for the query argument that is related to a property
        /// </summary>
        private class PropertyQueryArgumentInfo
        {
            #region Private Members

            /// <summary>
            /// The properties that define mappers
            /// </summary>
            private static readonly IEnumerable<PropertyInfo> mMapperProperties = typeof(GoogleMapsClientConstants).GetProperties();

            #endregion

            #region Public Properties

            /// <summary>
            /// The property
            /// </summary>
            public PropertyInfo PropertyInfo { get; }

            /// <summary>
            /// The name
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// A flag indicating whether the <see cref="PropertyInfo"/> is a date property
            /// </summary>
            public bool IsDate { get; }

            /// <summary>
            /// A flag indicating whether the <see cref="PropertyInfo"/> is an enumerable property
            /// </summary>
            public bool IsEnumerable { get; }

            /// <summary>
            /// The converter
            /// </summary>
            public IQueryArgumentConverter? Converter { get; }

            #endregion

            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            /// <param name="name">The name</param>
            /// <param name="propertyInfo">A flag indicating whether the <see cref="PropertyInfo"/> is an enumerable property</param>
            public PropertyQueryArgumentInfo(PropertyInfo propertyInfo, string name) : base()
            {
                PropertyInfo = propertyInfo ?? throw new ArgumentNullException(nameof(propertyInfo));
                Name = name.NotNullOrEmpty();

                IsDate = propertyInfo.PropertyType.IsDate();
                IsEnumerable = propertyInfo.PropertyType != typeof(string) && propertyInfo.PropertyType.IsEnumerable();

                Converter = propertyInfo.GetCustomAttribute<QueryArgumentConverterAttribute>()?.CreateConverter();
            }

            #endregion

            #region Public Methods

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            /// <returns></returns>
            public override string ToString() => Name;

            #endregion
        }

        #endregion
    }
}
