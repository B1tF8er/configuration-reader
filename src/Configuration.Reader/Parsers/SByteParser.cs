﻿namespace Configuration.Reader.Parsers
{
    using System;

    internal static class SByteParser
    {
        internal static Func<string, SettingResponse<sbyte>> Parse =>
            (configurationValue) =>
            {
                var parsed = sbyte.TryParse(configurationValue, out var someSByte);
                return SettingResponse<sbyte>.Create(parsed, someSByte);
            };
    }
}
