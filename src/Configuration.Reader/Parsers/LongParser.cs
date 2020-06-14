namespace Configuration.Reader.Parsers
{
    using System;

    internal static class LongParser
    {
        internal static Func<string, SettingResponse<long>> Parse =>
            (configurationValue) =>
                SettingResponse<long>.Create(
                    long.TryParse(configurationValue, out var someLong),
                    someLong
                );
    }
}
