namespace Configuration.Reader
{
    using System;

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
    }
}
