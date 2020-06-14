namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ShortParser
    {
        internal static Func<string, SettingResponse<short>> Parse =>
            (configurationValue) =>
                SettingResponse<short>.Create(
                    short.TryParse(configurationValue, out var someShort),
                    someShort
                );
    }
}
