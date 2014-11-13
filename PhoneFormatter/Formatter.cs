using JetBrains.Annotations;
using System;

namespace Bru.PhoneFormatter
{
    // TODO: Fill xml documentation.
    /// <summary>
    /// Returns the telephone number in the formatted form
    /// </summary>
    public class Formatter : IFormatter
    {
        internal const string _plus = "+";
        internal const long _minFguresPhoneNumber = 100000;
        internal const long _maxFguresPhoneNumber = 100000000;
        internal const int _maxFguresCode = 10000;

        public Formatter(
            [NotNull] long phoneNumber,
            [NotNull] int code,
            [NotNull] CountryPhoneCode countryCode)
        {
            if (phoneNumber < _minFguresPhoneNumber)
            {
                throw new FormatException("Phone number contains less than 6 figures.");
            }

            if (phoneNumber == 0)
            {
                throw new FormatException("Phone number is 0.");
            }

            if (phoneNumber > _maxFguresPhoneNumber)
            {
                throw new FormatException("Phone number contains more than 8 figures.");
            }

            if (code > _maxFguresCode)
            {
                throw new FormatException("Code contains less than 2 figures.");
            }

            if (Enum.IsDefined(typeof(CountryPhoneCode), countryCode) == false)
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("Country phone code is illegal enum value.");
            }

            PhoneNumber = phoneNumber;
            Code = code;
            CountryPhoneCode = countryCode;
        }

        public long PhoneNumber { get; private set; }

        public int Code { get; private set; }

        public CountryPhoneCode CountryPhoneCode { get; private set; }

        public FormattedPhoneNumber Format(PhoneFormat fullInternalNumber)
        {
            var _format = new FormattedPhoneNumber();
            var _countryPhoneCode = (int) CountryPhoneCode;
            var _phoneNumber = PhoneNumber.ToString();
            var _code = Code.ToString();

            if (Enum.IsDefined(typeof(PhoneFormat), fullInternalNumber) == false)
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("Phone format is illegal enum value.");
            }

            switch (fullInternalNumber)
            {
                case PhoneFormat.FullInternalNumber:
                    _format.E123 = _phoneNumber.Insert(0, _code).Insert(0, _countryPhoneCode.ToString()).Insert(0, _plus);
                    return _format;
                case PhoneFormat.FullInternationalNumber:
                    _format.E123 = _phoneNumber.Insert(0, _code).Insert(0, _countryPhoneCode.ToString()).Insert(0, _plus);
                    return _format;
                default:
                    return _format;
            }
        }
    }
}
