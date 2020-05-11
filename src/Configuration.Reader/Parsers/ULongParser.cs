namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ULongParser
    {
        internal static Func<string, SettingResponse<ulong>> Parse =>
            (configurationValue) => {
                var parsed = ulong.TryParse(configurationValue, out var someULong);
                return new SettingResponse<ulong>(parsed, someULong);
            };
    }
}
