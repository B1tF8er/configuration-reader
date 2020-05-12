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
            var expected = SettingResponse<bool>.Create(true, true);

            var actual = "Boolean_Test_One".TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetByteSetting()
        {
            var expected = SettingResponse<byte>.Create(true, 0123);

            var actual = "Byte_Test_One".TryGetByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCharSetting()
        {
            var expected = SettingResponse<char>.Create(true, 'a');

            var actual = "Char_Test_One".TryGetCharSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDecimalSetting()
        {
            var expected = SettingResponse<decimal>.Create(true, 1.9M);

            var actual = "Decimal_Test_One".TryGetDecimalSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDoubleSetting()
        {
            var expected = SettingResponse<double>.Create(true, 2.9D);

            var actual = "Double_Test_One".TryGetDoubleSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFloatSetting()
        {
            var expected = SettingResponse<float>.Create(true, 3.9F);

            var actual = "Float_Test_One".TryGetFloatSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntSetting()
        {
            var expected = SettingResponse<int>.Create(true, 4);

            var actual = "Int_Test_One".TryGetIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLongSetting()
        {
            var expected = SettingResponse<long>.Create(true, 5L);

            var actual = "Long_Test_One".TryGetLongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSByteSetting()
        {
            var expected = SettingResponse<sbyte>.Create(true, 0123);

            var actual = "SByte_Test_One".TryGetSByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortSetting()
        {
            var expected = SettingResponse<short>.Create(true, 6);

            var actual = "Short_Test_One".TryGetShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStringSetting()
        {
            var expected = SettingResponse<string>.Create(true, "test");

            var actual = "String_Test_One".TryGetStringSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUIntSetting()
        {
            var expected = SettingResponse<uint>.Create(true, 7);

            var actual = "UInt_Test_One".TryGetUIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetULongSetting()
        {
            var expected = SettingResponse<ulong>.Create(true, 8L);

            var actual = "ULong_Test_One".TryGetULongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUShortSetting()
        {
            var expected = SettingResponse<ushort>.Create(true, 9);

            var actual = "UShort_Test_One".TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotFindInvalidKey()
        {
            var key = "Test";
            var expected = SettingResponse<ushort>.Create(key.DoesNotExist());

            var actual = key.TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotParseInvalidValue()
        {
            var key = "Char_Test_One";
            var expected = SettingResponse<bool>.Create(key.ValueNotParsed());

            var actual = key.TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }
    }
}
