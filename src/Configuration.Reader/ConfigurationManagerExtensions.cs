namespace Configuration.Reader
{
    using System;
    using System.Configuration;

    public static partial class ConfigurationManagerExtensions
    {
        private static SettingResponse<TValue> TryGetSetting<TValue>(
            this string key, Func<string, SettingResponse<TValue>> parser)
        {
            var configurationValue = ConfigurationManager.AppSettings[key];

            if (configurationValue is null)
                return new SettingResponse<TValue>($"The key: {key.ToUpper()} does not exist in the configuration file.");

            var settingResponse = parser(configurationValue);

            return settingResponse.IsParsed
                ? settingResponse
                : new SettingResponse<TValue>($"The configuration value for key: {key.ToUpper()} could not be parsed.");
        }
    }
}
