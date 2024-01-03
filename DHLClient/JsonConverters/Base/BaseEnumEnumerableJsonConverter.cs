using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all the <see cref="JsonConverter{T}"/>s that are used for converting between an enumerable of <see cref="Enum"/>s and a <see cref="string"/>.
    /// </summary>
    public abstract class BaseEnumEnumerableJsonConverter<T> : JsonConverter<IEnumerable<T>>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumEnumerableJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override sealed IEnumerable<T> ReadJson(JsonReader reader, Type objectType, IEnumerable<T>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<IEnumerable<string>>(reader)!;

            return GetMapper().Where(x => readerValue.Contains(x.Value)).Select(x => x.Key).ToList();
        }

        /// <inheritdoc/> 
        public override sealed void WriteJson(JsonWriter writer, IEnumerable<T>? value, JsonSerializer serializer)
        {
            writer.WriteValue(GetMapper().Where(x => value?.Contains(x.Key) ?? false).AggregateString(","));
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets a <see cref="IReadOnlyDictionary{TKey, TValue}"/> that maps the values of the <typeparamref name="T"/>
        /// to <see cref="string"/>s
        /// </summary>
        /// <returns></returns>
        protected abstract IReadOnlyDictionary<T, string> GetMapper();

        #endregion
    }
}