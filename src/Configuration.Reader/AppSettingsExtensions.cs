namespace Configuration.Reader
{
    using System.Configuration;
    using static Constants.TestValues;

    internal static class AppSettingsExtensions
    {
        internal static string GetConfigurationValue(this string key) =>
            key.IsTestValue()
                ? key.GetTestConfigurationValue()
                : key.GetApplicationConfigurationValue();

        private static bool IsTestValue(this string key) =>
            key.StartsWith(TestKeyStart);

        private static string GetTestConfigurationValue(this string key) =>
            key switch
            {
                Boolean => "true",
                Byte => "0123",
                Char => "a",
                Decimal => "1.9",
                Double => "2.9",
                Float => "3.9",
                Int => "4",
                Long => "5",
                Object => "{ Number : 10, Text : \"Awesome\" }",
                SByte => "0123",
                Short => "6",
                String => "test",
                UInt => "7",
                ULong => "8",
                UShort => "9",
                NotFound => default,
                _ => default
            };

        private static string GetApplicationConfigurationValue(this string key) =>
            ConfigurationManager.AppSettings[key];
    }
}
