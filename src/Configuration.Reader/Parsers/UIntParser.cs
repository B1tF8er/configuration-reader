namespace Configuration.Reader.Parsers
{
    using System;

    internal static class UIntParser
    {
        internal static Func<string, SettingResponse<uint>> Parse =>
            (configurationValue) =>
            {
                var parsed = uint.TryParse(configurationValue, out var someUInt);
                return new SettingResponse<uint>(parsed, someUInt);
            };
    }
}
