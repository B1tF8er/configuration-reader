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

        [TestMethod]
        public void TryGetByteSetting()
        {
            var expected = new SettingResponse<byte>(true, 0123);

            var actual = ConfigurationManagerExtensions.TryGetByteSetting("Byte_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetCharSetting()
        {
            var expected = new SettingResponse<char>(true, 'a');

            var actual = ConfigurationManagerExtensions.TryGetCharSetting("Char_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetDecimalSetting()
        {
            var expected = new SettingResponse<decimal>(true, 1.9M);

            var actual = ConfigurationManagerExtensions.TryGetDecimalSetting("Decimal_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetDoubleSetting()
        {
            var expected = new SettingResponse<double>(true, 2.9D);

            var actual = ConfigurationManagerExtensions.TryGetDoubleSetting("Double_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetFloatSetting()
        {
            var expected = new SettingResponse<float>(true, 3.9F);

            var actual = ConfigurationManagerExtensions.TryGetFloatSetting("Float_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetIntSetting()
        {
            var expected = new SettingResponse<float>(true, 4);

            var actual = ConfigurationManagerExtensions.TryGetIntSetting("Int_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetLongSetting()
        {
            var expected = new SettingResponse<long>(true, 5L);

            var actual = ConfigurationManagerExtensions.TryGetLongSetting("Long_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetSByteSetting()
        {
            var expected = new SettingResponse<sbyte>(true, 0123);

            var actual = ConfigurationManagerExtensions.TryGetSByteSetting("SByte_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetShortSetting()
        {
            var expected = new SettingResponse<short>(true, 6);

            var actual = ConfigurationManagerExtensions.TryGetShortSetting("Short_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetStringSetting()
        {
            var expected = new SettingResponse<string>(true, "test");

            var actual = ConfigurationManagerExtensions.TryGetStringSetting("String_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetUIntSetting()
        {
            var expected = new SettingResponse<uint>(true, 7);

            var actual = ConfigurationManagerExtensions.TryGetUIntSetting("UInt_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetULongSetting()
        {
            var expected = new SettingResponse<ulong>(true, 8L);

            var actual = ConfigurationManagerExtensions.TryGetULongSetting("ULong_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }

        [TestMethod]
        public void TryGetUShortSetting()
        {
            var expected = new SettingResponse<ushort>(true, 9);

            var actual = ConfigurationManagerExtensions.TryGetUShortSetting("UShort_Test_One");

            Assert.AreEqual(expected.IsParsed, actual.IsParsed);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Error, actual.Error);
        }
    }
}
