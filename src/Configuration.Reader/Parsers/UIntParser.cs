namespace Configuration.Reader.Parsers
{
    using System;

    internal static class UIntParser
    {
        internal static Func<string, SettingResponse<uint>> Parse =>
            (configurationValue) =>
                SettingResponse<uint>.Create(
                    uint.TryParse(configurationValue, out var someUInt),
                    someUInt
                );
    }
}
