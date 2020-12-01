namespace Configuration.Reader
{
    using static Newtonsoft.Json.JsonConvert;

    internal static class JsonConvertExtensions
    {
        internal static TResponse DeserializeTo<TResponse>(this string value)
            => DeserializeObject<TResponse>(value);

        internal static bool TryDeserializeTo<TResponse>(this string value, out TResponse response)
        {
            try
            {
                response = value.DeserializeTo<TResponse>();
                return true;
            }
            catch
            {
                response = default;
                return false;
            }
        }
    }
}
