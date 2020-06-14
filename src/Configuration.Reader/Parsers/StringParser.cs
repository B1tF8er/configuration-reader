namespace Configuration.Reader.Parsers
{
    using System;

    internal static class StringParser
    {
        internal static Func<string, SettingResponse<string>> Parse =>
            (configurationValue) =>
                SettingResponse<string>.Create(
                    true,
                    configurationValue
                );
    }
}
