namespace Configuration.Reader.Parsers
{
    using System;

    internal static class CharParser
    {
        internal static Func<string, SettingResponse<char>> Parse =>
            (configurationValue) =>
            {
                var parsed = char.TryParse(configurationValue, out var someChar);
                return new SettingResponse<char>(parsed, someChar);
            };
    }
}
