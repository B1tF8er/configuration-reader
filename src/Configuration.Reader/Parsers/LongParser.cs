namespace Configuration.Reader.Parsers
{
    using System;

    internal static class LongParser
    {
        internal static Func<string, SettingResponse<long>> Parse =>
            (configurationValue) =>
            {
                var parsed = long.TryParse(configurationValue, out var someLong);
                return SettingResponse<long>.Create(parsed, someLong);
            };
    }
}
