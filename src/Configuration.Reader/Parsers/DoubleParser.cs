namespace Configuration.Reader.Parsers
{
    using System;

    internal static class DoubleParser
    {
        internal static Func<string, SettingResponse<double>> Parse =>
            (configurationValue) =>
            {
                var parsed = double.TryParse(configurationValue, out var someDouble);
                return new SettingResponse<double>(parsed, someDouble);
            };
    }
}
