namespace Configuration.Reader.Parsers
{
    using System;

    internal static class UShortParser
    {
        internal static Func<string, SettingResponse<ushort>> Parse =>
            (configurationValue) =>
                SettingResponse<ushort>.Create(
                    ushort.TryParse(configurationValue, out var someUShort),
                    someUShort
                );
    }
}
