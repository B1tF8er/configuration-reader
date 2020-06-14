namespace Configuration.Reader
{
    using System;
    using System.Configuration;

    public static partial class ConfigurationManagerExtensions
    {
        private static SettingResponse<TValue> TryGetSetting<TValue>(
            this string key, Func<string, SettingResponse<TValue>> parser)
        {
            var configurationValue = key.GetConfigurationValue();

            if (configurationValue is null)
                return SettingResponse<TValue>.Create(key.DoesNotExist());

            var settingResponse = parser(configurationValue);

            return settingResponse.IsParsed
                ? settingResponse
                : SettingResponse<TValue>.Create(key.ValueNotParsed());
        }

        private static string GetConfigurationValue(this string key) =>
            key switch
            {
                "Test_Boolean" => "true",
                "Test_Byte" => "0123",
                "Test_Char" => "a",
                "Test_Decimal" => "1.9",
                "Test_Double" => "2.9",
                "Test_Float" => "3.9",
                "Test_Int" => "4",
                "Test_Long" => "5",
                "Test_SByte" => "0123",
                "Test_Short" => "6",
                "Test_String" => "test",
                "Test_UInt" => "7",
                "Test_ULong" => "8",
                "Test_UShort" => "9",
                "Test_NotFound" => default,
                _ => ConfigurationManager.AppSettings[key]
            };
    }
}
