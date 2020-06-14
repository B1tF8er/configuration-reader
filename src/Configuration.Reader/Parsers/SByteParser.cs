namespace Configuration.Reader.Parsers
{
    using System;

    internal static class SByteParser
    {
        internal static Func<string, SettingResponse<sbyte>> Parse =>
            (configurationValue) =>
                SettingResponse<sbyte>.Create(
                    sbyte.TryParse(configurationValue, out var someSByte),
                    someSByte
                );
    }
}
