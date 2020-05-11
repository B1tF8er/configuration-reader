﻿namespace Configuration.Reader.Parsers
{
    using System;

    internal static class ShortParser
    {
        internal static Func<string, SettingResponse<short>> Parse =>
            (configurationValue) => {
                var parsed = short.TryParse(configurationValue, out var someShort);
                return new SettingResponse<short>(parsed, someShort);
            };
    }
}