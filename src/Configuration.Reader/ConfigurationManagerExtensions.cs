namespace Configuration.Reader
{
    using Parsers;
    using System;
    using System.Configuration;

    public static class ConfigurationManagerExtensions
    {
		internal static SettingResponse<bool> TryGetBoolSetting(this string key)
			=> key.TryGetSetting(BoolParser.Parse);

		internal static SettingResponse<decimal> TryGetDecimalSetting(this string key)
			=> key.TryGetSetting(DecimalParser.Parse);

		internal static SettingResponse<double> TryGetDoubleSetting(this string key)
			=> key.TryGetSetting(DoubleParser.Parse);

		internal static SettingResponse<int> TryGetIntSetting(this string key)
			=> key.TryGetSetting(IntParser.Parse);

		internal static SettingResponse<long> TryGetLongSetting(this string key)
			=> key.TryGetSetting(LongParser.Parse);

		internal static SettingResponse<string> TryGetStringSetting(this string key)
			=> key.TryGetSetting(StringParser.Parse);

		private static SettingResponse<T> TryGetSetting<T>(this string key, Func<string, SettingResponse<T>> parser)
		{
			var configurationValue = ConfigurationManager.AppSettings[key];

			if (configurationValue is null)
				return new SettingResponse<T>("The key does not exist in the configuration file.");

			var settingResponse = parser(configurationValue);

			if (!settingResponse.IsParsed)
				return new SettingResponse<T>($"The configuration value for key: {key.ToUpper()} could not be parsed.");

			return settingResponse;
		}
	}
}
