namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ULongParser
    {
        internal static Func<string, SettingResponse<ulong>> Parse =>
            (configurationValue) =>
                SettingResponse<ulong>.Create(
                    ulong.TryParse(configurationValue, out var someULong),
                    someULong
                );
    }
}
