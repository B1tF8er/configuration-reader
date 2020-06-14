namespace Configuration.Reader
{
    using static Newtonsoft.Json.JsonConvert;

    internal static class JsonConvertExtensions
    {
        internal static TResponse DeserializeTo<TResponse>(this string value)
            => DeserializeObject<TResponse>(value);
    }
}
