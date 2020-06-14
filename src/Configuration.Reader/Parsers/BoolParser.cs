namespace Configuration.Reader.Parsers
{
    using System;

    internal static class BoolParser
    {
        internal static Func<string, SettingResponse<bool>> Parse =>
            (configurationValue) =>
                SettingResponse<bool>.Create(
                    bool.TryParse(configurationValue, out var someBool),
                    someBool
                );
    }
}
