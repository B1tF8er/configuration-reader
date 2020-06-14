namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ByteParser
    {
        internal static Func<string, SettingResponse<byte>> Parse =>
            (configurationValue) =>
                SettingResponse<byte>.Create(
                    byte.TryParse(configurationValue, out var someByte),
                    someByte
                );
    }
}
