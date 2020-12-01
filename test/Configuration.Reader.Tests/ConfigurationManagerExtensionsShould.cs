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

            var actual = "Test_Boolean".TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetByteSetting()
        {
            var expected = SettingResponse<byte>.Create(true, 0123);

            var actual = "Test_Byte".TryGetByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCharSetting()
        {
            var expected = SettingResponse<char>.Create(true, 'a');

            var actual = "Test_Char".TryGetCharSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDecimalSetting()
        {
            var expected = SettingResponse<decimal>.Create(true, 1.9M);

            var actual = "Test_Decimal".TryGetDecimalSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDoubleSetting()
        {
            var expected = SettingResponse<double>.Create(true, 2.9D);

            var actual = "Test_Double".TryGetDoubleSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFloatSetting()
        {
            var expected = SettingResponse<float>.Create(true, 3.9F);

            var actual = "Test_Float".TryGetFloatSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntSetting()
        {
            var expected = SettingResponse<int>.Create(true, 4);

            var actual = "Test_Int".TryGetIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLongSetting()
        {
            var expected = SettingResponse<long>.Create(true, 5L);

            var actual = "Test_Long".TryGetLongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetObjectSetting()
        {
            var sample = new Sample { Number = 10, Text = "Awesome" };
            var expected = SettingResponse<Sample>.Create(true, sample);

            var actual = "Test_Object".TryGetObjectSetting<Sample>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSByteSetting()
        {
            var expected = SettingResponse<sbyte>.Create(true, 0123);

            var actual = "Test_SByte".TryGetSByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortSetting()
        {
            var expected = SettingResponse<short>.Create(true, 6);

            var actual = "Test_Short".TryGetShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStringSetting()
        {
            var expected = SettingResponse<string>.Create(true, "test");

            var actual = "Test_String".TryGetStringSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUIntSetting()
        {
            var expected = SettingResponse<uint>.Create(true, 7);

            var actual = "Test_UInt".TryGetUIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetULongSetting()
        {
            var expected = SettingResponse<ulong>.Create(true, 8L);

            var actual = "Test_ULong".TryGetULongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUShortSetting()
        {
            var expected = SettingResponse<ushort>.Create(true, 9);

            var actual = "Test_UShort".TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotFindInvalidKey()
        {
            var key = "Test_NotFound";
            var expected = SettingResponse<ushort>.Create(key.DoesNotExist());

            var actual = key.TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotParseInvalidValue()
        {
            var key = "Test_Char";
            var expected = SettingResponse<bool>.Create(key.ValueNotParsed());

            var actual = key.TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotParseInvalidObject()
        {
            var key = "Test_Char";
            var expected = SettingResponse<Sample>.Create(key.ValueNotParsed());

            var actual = key.TryGetObjectSetting<Sample>();

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
