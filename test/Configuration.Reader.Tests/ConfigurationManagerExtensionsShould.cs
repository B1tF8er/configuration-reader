namespace Configuration.Reader.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using static ConfigurationManagerExtensions;

    [TestClass]
    public class ConfigurationManagerExtensionsShould
    {
        [TestMethod]
        public void GetBoolSetting()
        {
            var expected = new SettingResponse<bool>(true, true);

            var actual = "Boolean_Test_One".TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetByteSetting()
        {
            var expected = new SettingResponse<byte>(true, 0123);

            var actual = "Byte_Test_One".TryGetByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCharSetting()
        {
            var expected = new SettingResponse<char>(true, 'a');

            var actual = "Char_Test_One".TryGetCharSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDecimalSetting()
        {
            var expected = new SettingResponse<decimal>(true, 1.9M);

            var actual = "Decimal_Test_One".TryGetDecimalSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDoubleSetting()
        {
            var expected = new SettingResponse<double>(true, 2.9D);

            var actual = "Double_Test_One".TryGetDoubleSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFloatSetting()
        {
            var expected = new SettingResponse<float>(true, 3.9F);

            var actual = "Float_Test_One".TryGetFloatSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntSetting()
        {
            var expected = new SettingResponse<int>(true, 4);

            var actual = "Int_Test_One".TryGetIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLongSetting()
        {
            var expected = new SettingResponse<long>(true, 5L);

            var actual = "Long_Test_One".TryGetLongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSByteSetting()
        {
            var expected = new SettingResponse<sbyte>(true, 0123);

            var actual = "SByte_Test_One".TryGetSByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortSetting()
        {
            var expected = new SettingResponse<short>(true, 6);

            var actual = "Short_Test_One".TryGetShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStringSetting()
        {
            var expected = new SettingResponse<string>(true, "test");

            var actual = "String_Test_One".TryGetStringSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUIntSetting()
        {
            var expected = new SettingResponse<uint>(true, 7);

            var actual = "UInt_Test_One".TryGetUIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetULongSetting()
        {
            var expected = new SettingResponse<ulong>(true, 8L);

            var actual = "ULong_Test_One".TryGetULongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUShortSetting()
        {
            var expected = new SettingResponse<ushort>(true, 9);

            var actual = "UShort_Test_One".TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotFindInvalidKey()
        {
            var key = "Test";
            var error = $"The key: {key.ToUpper()} does not exist in the configuration file.";
            var expected = new SettingResponse<ushort>(error);

            var actual = key.TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotParseInvalidValue()
        {
            var key = "Char_Test_One";
            var error = $"The configuration value for key: {key.ToUpper()} could not be parsed.";
            var expected = new SettingResponse<bool>(error);

            var actual = key.TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }
    }
}
