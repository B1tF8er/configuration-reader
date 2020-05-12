namespace Configuration.Reader.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConfigurationManagerExtensionsShould
    {
        [TestMethod]
        public void TryGetBoolSetting()
        {
            var expected = new SettingResponse<bool>(true, true);

            var actual = ConfigurationManagerExtensions.TryGetBoolSetting("Boolean_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }
    }
}
