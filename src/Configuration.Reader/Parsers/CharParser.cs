namespace Configuration.Reader.Parsers
{
    using System;

    internal static class CharParser
    {
        internal static Func<string, SettingResponse<char>> Parse =>
            (configurationValue) =>
                SettingResponse<char>.Create(
                    char.TryParse(configurationValue, out var someChar),
                    someChar
                );
    }
}
