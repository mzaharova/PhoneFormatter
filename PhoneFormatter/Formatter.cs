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
        private const string Plus = "+";
        private const long MinFguresPhoneNumber = 100000;
        private const long MaxFguresPhoneNumber = 100000000;

        public Formatter(
            [NotNull] long phoneNumber,
            [NotNull] int code,
            [NotNull] CountryPhoneCode countryCode)
        {
            if (phoneNumber < MinFguresPhoneNumber)
            {
                throw new FormatException("Phone number contains less than 6 figures.");
            }

            if (phoneNumber == 0)
            {
                throw new FormatException("Phone number is 0.");
            }

            if (phoneNumber > MaxFguresPhoneNumber)
            {
                throw new FormatException("Phone number contains more than 8 figures.");
            }

            if (Enum.IsDefined(typeof (CountryPhoneCode), countryCode) == false)
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("Country phone code is illegal enum value.");
            }

            if (code.ToString().Length + phoneNumber.ToString().Length != 12 - ((int) countryCode).ToString().Length)
            {
                throw new FormatException("Code contains less than 2 figures.");
            }

            PhoneNumber = phoneNumber;
            Code = code;
            CountryPhoneCode = countryCode;
        }

        public long PhoneNumber { get; private set; }

        public int Code { get; private set; }

        public CountryPhoneCode CountryPhoneCode { get; private set; }

        public FormattedPhoneNumber Format()
        {
            var format = new FormattedPhoneNumber
            {
                E123 = Plus + (int) CountryPhoneCode + Code + PhoneNumber,
            };

            return format;
        }
    }
}
