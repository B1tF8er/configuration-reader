namespace Configuration.Reader
{
    public static class SettingResponseErrors
    {
        public static Error ValueNotParsed(this string key) =>
            $"The configuration value for key: {key.ToUpper()} could not be parsed.";

        public static Error DoesNotExist(this string key) =>
            $"The key: {key.ToUpper()} does not exist in the configuration file.";
    }
}
