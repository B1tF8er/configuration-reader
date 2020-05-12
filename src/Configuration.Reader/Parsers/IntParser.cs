namespace Configuration.Reader.Parsers
{
    using System;

    internal static class IntParser
    {
        internal static Func<string, SettingResponse<int>> Parse =>
            (configurationValue) =>
            {
                var parsed = int.TryParse(configurationValue, out var someInt);
                return SettingResponse<int>.Create(parsed, someInt);
            };
    }
}
