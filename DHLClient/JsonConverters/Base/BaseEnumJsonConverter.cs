using Newtonsoft.Json;

namespace DHLClient
{
    /// <summary>
    /// The base for all the <see cref="JsonConverter{T}"/>s that are used for converting between an <see cref="Enum"/> and a <see cref="string"/>
    /// </summary>
    public abstract class BaseEnumJsonConverter<T> : JsonConverter<T?>
        where T : struct, Enum
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override sealed T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader);

            if (readerValue.IsNullOrEmpty())
                return null;

            return GetMapper().First(x => x.Value == readerValue).Key;
        }

        /// <inheritdoc/>
        public override sealed void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            writer.WriteValue(GetMapper()[value.Value!]);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets a <see cref="IReadOnlyDictionary{TKey, TValue}"/> that maps the values of the <see cref="T"/> to <see cref="string"/>s
        /// </summary>
        /// <returns></returns>
        protected abstract IReadOnlyDictionary<T, string> GetMapper();

        #endregion
    }
}
