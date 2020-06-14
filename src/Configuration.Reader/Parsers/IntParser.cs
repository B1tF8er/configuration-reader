namespace Configuration.Reader.Parsers
{
    using System;

    internal static class IntParser
    {
        internal static Func<string, SettingResponse<int>> Parse =>
            (configurationValue) =>
                SettingResponse<int>.Create(
                    int.TryParse(configurationValue, out var someInt),
                    someInt
                );
    }
}
