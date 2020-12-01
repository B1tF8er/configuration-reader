namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ObjectParser<TObject>
    {
        internal static Func<string, SettingResponse<TObject>> Parse =>
            (configurationValue) =>
                SettingResponse<TObject>.Create(
                    configurationValue.TryDeserializeTo<TObject>(out var someObject),
                    someObject
                );
    }
}
