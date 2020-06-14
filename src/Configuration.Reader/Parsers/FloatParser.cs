namespace Configuration.Reader.Parsers
{
    using System;

    internal static class FloatParser
    {
        internal static Func<string, SettingResponse<float>> Parse =>
            (configurationValue) =>
                SettingResponse<float>.Create(
                    float.TryParse(configurationValue, out var someFloat),
                    someFloat
                );
    }
}
