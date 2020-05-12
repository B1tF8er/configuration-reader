namespace Configuration.Reader.Parsers
{
    using System;

    internal static class DoubleParser
    {
        internal static Func<string, SettingResponse<double>> Parse =>
            (configurationValue) =>
            {
                var parsed = double.TryParse(configurationValue, out var someDouble);
                return SettingResponse<double>.Create(parsed, someDouble);
            };
    }
}
