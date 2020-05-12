namespace Configuration.Reader
{
    public static class SettingResponseErrors
    {
        public static string ValueNotParsed(this string key) =>
            $"The configuration value for key: {key.ToUpper()} could not be parsed.";

        public static string DoesNotExist(this string key) =>
            $"The key: {key.ToUpper()} does not exist in the configuration file.";
    }
}
