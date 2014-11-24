using JetBrains.Annotations;

namespace Bru.PhoneFormatter
{
    public class FormattedPhoneNumber
    {
        private const string Minus = "-";
        private const string Null = "0";
        private const string CodeBelarus = "8";

        // SEE: http://en.wikipedia.org/wiki/E.123
        // TODO: Fill xml documentation.
        /// <summary>
        /// Phone number - the E.123 standard 
        /// </summary>
        [NotNull]
        public string E123 { get; set; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// Phone number format for Belarus
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public string GetNationalFormattedPhone(long phoneNumber, int code, CountryPhoneCode countryPhoneCode)
        {
            if (countryPhoneCode != CountryPhoneCode.Belarus)
            {
                throw new System.InvalidOperationException(); 
            }

            var phone = CodeBelarus + Minus + Null + code + Minus + phoneNumber;
            return phone;
        }
    }
}
