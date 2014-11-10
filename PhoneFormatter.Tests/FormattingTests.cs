using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bru.PhoneFormatter.Tests
{
    [TestClass]
    public class FormattingTests
    {
        [TestMethod]
        // TODO: Add description.
        public void ResultNotNullTest()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();

            // TODO: Add message.
            Assert.IsNotNull(formattedPhoneNumber);
        }

        #region E123 format tests

        [TestMethod]
        // TODO: Add description.
        public void E123FormatTest1()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();

            // TODO: Add message.
            Assert.IsNotNull(formattedPhoneNumber.E123);

            // TODO: Add message.
            Assert.AreEqual("+375222284444", formattedPhoneNumber.E123);
        }

        [TestMethod]
        // TODO: Add description.
        public void E123FormatTest2()
        {
            const long phoneNumber = 11234567;
            const int code = 42;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Netherlands;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();

            // TODO: Add message.
            Assert.IsNotNull(formattedPhoneNumber.E123);

            // TODO: Add message.
            Assert.AreEqual("+314211234567", formattedPhoneNumber.E123);
        }
        #endregion

        #region National format tests

        [TestMethod]
        // TODO: Add description.
        [ExpectedException(typeof(InvalidOperationException))]
        public void NationalFormatWithInvalidCountryConeTest1()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Afghanistan;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();
            formattedPhoneNumber.GetNationalFormattedPhone();
        }

        [TestMethod]
        // TODO: Add description.
        [ExpectedException(typeof(InvalidOperationException))]
        public void NationalFormatWithInvalidCountryConeTest2()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Afghanistan;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();
            var nationalFormattedPhone = formattedPhoneNumber.ToString();

            // TODO: Add message.
            Assert.AreEqual(string.Empty, nationalFormattedPhone);
        }

        [TestMethod]
        // TODO: Add description.
        public void NationalFormatTest1()
        {
            const long phoneNumber = 284444;
            const int code = 222;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();
            var nationalFormattedPhone = formattedPhoneNumber.GetNationalFormattedPhone();

            // TODO: Add message.
            Assert.IsNotNull(nationalFormattedPhone);

            // TODO: Add message.
            Assert.AreEqual("8-0222-284444", nationalFormattedPhone);

            // TODO: Add message.
            Assert.AreEqual("+375222284444", formattedPhoneNumber.E123);

            // TODO: Add message.
            Assert.AreEqual(nationalFormattedPhone, formattedPhoneNumber.ToString());
        }

        [TestMethod]
        // TODO: Add description.
        public void NationalFormatTest2()
        {
            const long phoneNumber = 6284444;
            const int code = 29;
            const CountryPhoneCode countryPhoneCode = CountryPhoneCode.Belarus;

            IFormatter formatter = new Formatter(phoneNumber, code, countryPhoneCode);

            var formattedPhoneNumber = formatter.Format();
            var nationalFormattedPhone = formattedPhoneNumber.GetNationalFormattedPhone();

            // TODO: Add message.
            Assert.IsNotNull(nationalFormattedPhone);

            // TODO: Add message.
            Assert.AreEqual("8-029-6284444", nationalFormattedPhone);

            // TODO: Add message.
            Assert.AreEqual("+375296284444", formattedPhoneNumber.E123);

            // TODO: Add message.
            Assert.AreEqual(nationalFormattedPhone, formattedPhoneNumber.ToString());
        }
        #endregion
    }
}
