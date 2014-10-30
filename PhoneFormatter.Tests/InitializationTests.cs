using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bru.PhoneFormatter.Tests
{
    [TestClass]
    public class InitializationTests
    {
        [TestMethod]
        public void SimpleInitializationTest()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            // TODO: Add message.
            Assert.AreEqual(phoneNumber, formatter.PhoneNumber);

            // TODO: Add message.
            Assert.AreEqual(code, formatter.Code);

            // TODO: Add message.
            Assert.AreEqual(countryPhoneCode, formatter.CountryPhoneCode);
        }

        #region Phone number validations

        [TestMethod]
        [Description("Phone number is 0.")]
        // TODO: Add message.
        [ExpectedException(typeof(FormatException))]
        public void PhoneNumberValidationTest1()
        {
            const long phoneNumber = 0;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            // ReSharper disable once ObjectCreationAsStatement
            new Formatter(phoneNumber, code, countryPhoneCode);
        }

        [TestMethod]
        [Description("Phone number contains less than 6 figures.")]
        // TODO: Add message.
        [ExpectedException(typeof(FormatException))]
        public void PhoneNumberValidationTest2()
        {
            const long phoneNumber = 99999;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            // ReSharper disable once ObjectCreationAsStatement
            new Formatter(phoneNumber, code, countryPhoneCode);
        }

        [TestMethod]
        [Description("Phone number contains more than 8 figures.")]
        // TODO: Add message.
        [ExpectedException(typeof(FormatException))]
        public void PhoneNumberValidationTest3()
        {
            const long phoneNumber = 999999999;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            // ReSharper disable once ObjectCreationAsStatement
            new Formatter(phoneNumber, code, countryPhoneCode);
        }
        #endregion

        #region Code validations

        [TestMethod]
        [Description("Code contains less than 2 figures.")]
        // TODO: Add message.
        [ExpectedException(typeof(FormatException))]
        public void CodeValidationTest1()
        {
            const long phoneNumber = 284444;
            const int code = 1;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            // ReSharper disable once ObjectCreationAsStatement
            new Formatter(phoneNumber, code, countryPhoneCode);
        }

        [TestMethod]
        [Description("Code contains more than 4 figures.")]
        // TODO: Add message.
        [ExpectedException(typeof(FormatException))]
        public void CodeValidationTest2()
        {
            const long phoneNumber = 284444;
            const int code = 99999;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            // ReSharper disable once ObjectCreationAsStatement
            new Formatter(phoneNumber, code, countryPhoneCode);
        }
        #endregion

        #region Country phone code validations

        [TestMethod]
        [Description("Country phone code is illegal enum value.")]
        // TODO: Add message.
        [ExpectedException(typeof(System.ComponentModel.InvalidEnumArgumentException))]
        public void CountryPhoneCodeValidationTest1()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = (CountryPhoneCode)1000;

            // ReSharper disable once ObjectCreationAsStatement
            new Formatter(phoneNumber, code, countryPhoneCode);
        }
        #endregion
    }
}
