namespace Configuration.Reader.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using static ConfigurationManagerExtensions;
    using static Constants.TestValues;

    [TestClass]
    public class ConfigurationManagerExtensionsShould
    {
        [TestMethod]
        public void GetBoolSetting()
        {
            var expected = SettingResponse<bool>.Create(true, true);

            var actual = Boolean.TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetByteSetting()
        {
            var expected = SettingResponse<byte>.Create(true, 0123);

            var actual = Byte.TryGetByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCharSetting()
        {
            var expected = SettingResponse<char>.Create(true, 'a');

            var actual = Char.TryGetCharSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDecimalSetting()
        {
            var expected = SettingResponse<decimal>.Create(true, 1.9M);

            var actual = Decimal.TryGetDecimalSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDoubleSetting()
        {
            var expected = SettingResponse<double>.Create(true, 2.9D);

            var actual = Double.TryGetDoubleSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFloatSetting()
        {
            var expected = SettingResponse<float>.Create(true, 3.9F);

            var actual = Float.TryGetFloatSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntSetting()
        {
            var expected = SettingResponse<int>.Create(true, 4);

            var actual = Int.TryGetIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLongSetting()
        {
            var expected = SettingResponse<long>.Create(true, 5L);

            var actual = Long.TryGetLongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetObjectSetting()
        {
            var sample = new Sample { Number = 10, Text = "Awesome" };
            var expected = SettingResponse<Sample>.Create(true, sample);

            var actual = Object.TryGetObjectSetting<Sample>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSByteSetting()
        {
            var expected = SettingResponse<sbyte>.Create(true, 0123);

            var actual = SByte.TryGetSByteSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortSetting()
        {
            var expected = SettingResponse<short>.Create(true, 6);

            var actual = Short.TryGetShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStringSetting()
        {
            var expected = SettingResponse<string>.Create(true, "test");

            var actual = String.TryGetStringSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUIntSetting()
        {
            var expected = SettingResponse<uint>.Create(true, 7);

            var actual = UInt.TryGetUIntSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetULongSetting()
        {
            var expected = SettingResponse<ulong>.Create(true, 8L);

            var actual = ULong.TryGetULongSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUShortSetting()
        {
            var expected = SettingResponse<ushort>.Create(true, 9);

            var actual = UShort.TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotFindInvalidKey()
        {
            var expected = SettingResponse<ushort>.Create(NotFound.DoesNotExist());

            var actual = NotFound.TryGetUShortSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotParseInvalidValue()
        {
            var expected = SettingResponse<bool>.Create(Char.ValueNotParsed());

            var actual = Char.TryGetBoolSetting();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotParseInvalidObject()
        {
            var expected = SettingResponse<Sample>.Create(Char.ValueNotParsed());

            var actual = Char.TryGetObjectSetting<Sample>();

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
