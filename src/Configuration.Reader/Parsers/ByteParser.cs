namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ByteParser
    {
        internal static Func<string, SettingResponse<byte>> Parse =>
            (configurationValue) => {
                var parsed = byte.TryParse(configurationValue, out var someByte);
                return new SettingResponse<byte>(parsed, someByte);
            };
    }
}
