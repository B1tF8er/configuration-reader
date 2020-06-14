namespace Configuration.Reader.Parsers
{
    using System;

    internal static class DoubleParser
    {
        internal static Func<string, SettingResponse<double>> Parse =>
            (configurationValue) =>
                SettingResponse<double>.Create(
                    double.TryParse(configurationValue, out var someDouble),
                    someDouble
                );
    }
}
