namespace Configuration.Reader.Parsers
{
    using System;

    internal static class IntParser
    {
        internal static Func<string, SettingResponse<int>> Parse =>
            (configurationValue) => {
                var parsed = int.TryParse(configurationValue, out var someInt);
                return new SettingResponse<int>(parsed, someInt);
            };
    }
}
