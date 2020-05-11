namespace Configuration.Reader.Parsers
{
    using System;

    internal static class DecimalParser
    {
        internal static Func<string, SettingResponse<decimal>> Parse =>
            (configurationValue) => {
                var parsed = decimal.TryParse(configurationValue, out var someDecimal);
                return new SettingResponse<decimal>(parsed, someDecimal);
            };
    }
}
