namespace Configuration.Reader
{
	using Parsers;

	public static partial class ConfigurationManagerExtensions
    {
		public static SettingResponse<bool> TryGetBoolSetting(this string key)
			=> key.TryGetSetting(BoolParser.Parse);

		public static SettingResponse<byte> TryGetByteSetting(this string key)
			=> key.TryGetSetting(ByteParser.Parse);

		public static SettingResponse<char> TryGetCharSetting(this string key)
			=> key.TryGetSetting(CharParser.Parse);

		public static SettingResponse<decimal> TryGetDecimalSetting(this string key)
			=> key.TryGetSetting(DecimalParser.Parse);

		public static SettingResponse<double> TryGetDoubleSetting(this string key)
			=> key.TryGetSetting(DoubleParser.Parse);

		public static SettingResponse<float> TryGetFloatSetting(this string key)
			=> key.TryGetSetting(FloatParser.Parse);

		public static SettingResponse<int> TryGetIntSetting(this string key)
			=> key.TryGetSetting(IntParser.Parse);

		public static SettingResponse<long> TryGetLongSetting(this string key)
			=> key.TryGetSetting(LongParser.Parse);

		public static SettingResponse<sbyte> TryGetSByteSetting(this string key)
			=> key.TryGetSetting(SByteParser.Parse);

		public static SettingResponse<short> TryGetShortSetting(this string key)
			=> key.TryGetSetting(ShortParser.Parse);

		public static SettingResponse<string> TryGetStringSetting(this string key)
			=> key.TryGetSetting(StringParser.Parse);
	}
}
