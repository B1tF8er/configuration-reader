namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ObjectParser<TObject>
    {
        internal static Func<string, SettingResponse<TObject>> Parse =>
            (configurationValue) =>
                SettingResponse<TObject>.Create(
                    true,
                    configurationValue.DeserializeTo<TObject>()
                );
    }
}
