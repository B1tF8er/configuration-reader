namespace Configuration.Reader.Parsers
{
    using System;

    internal static class FloatParser
    {
        internal static Func<string, SettingResponse<float>> Parse =>
            (configurationValue) => {
                var parsed = float.TryParse(configurationValue, out var someFloat);
                return new SettingResponse<float>(parsed, someFloat);
            };
    }
}
