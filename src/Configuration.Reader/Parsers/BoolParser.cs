namespace Configuration.Reader.Parsers
{
    using System;

    internal static class BoolParser
    {
        internal static Func<string, SettingResponse<bool>> Parse =>
            (configurationValue) => {
                var parsed = bool.TryParse(configurationValue, out var someBool);
                return new SettingResponse<bool>(parsed, someBool);
            };
    }
}
