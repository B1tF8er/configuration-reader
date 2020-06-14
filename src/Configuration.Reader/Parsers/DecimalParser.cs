namespace Configuration.Reader.Parsers
{
    using System;

    internal static class DecimalParser
    {
        internal static Func<string, SettingResponse<decimal>> Parse =>
            (configurationValue) =>
                SettingResponse<decimal>.Create(
                    decimal.TryParse(configurationValue, out var someDecimal),
                    someDecimal
                );
    }
}
