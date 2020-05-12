namespace Configuration.Reader.Parsers
{
    using System;

    internal static class UShortParser
    {
        internal static Func<string, SettingResponse<ushort>> Parse =>
            (configurationValue) =>
            {
                var parsed = ushort.TryParse(configurationValue, out var someUShort);
                return SettingResponse<ushort>.Create(parsed, someUShort);
            };
    }
}
