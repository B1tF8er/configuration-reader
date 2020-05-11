namespace Configuration.Reader.Tests
{
    using Xunit;

    public class ConfigurationManagerExtensionsShould
    {
        [Fact]
        public void TryGetBoolSetting()
        {
            var expected = new SettingResponse<bool>("The key does not exist in the configuration file.");

            var actual = ConfigurationManagerExtensions.TryGetBoolSetting("Boolean_Test_One");

            Assert.Equal(expected.IsParsed, actual.IsParsed);
            Assert.Equal(expected.Value, actual.Value);
            Assert.Equal(expected.Error, actual.Error);
        }
    }
}
