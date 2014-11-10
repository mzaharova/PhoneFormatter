using JetBrains.Annotations;

namespace Bru.PhoneFormatter
{
    // TODO: Fill xml documentation.
    /// <summary>
    /// 
    /// </summary>
    public class Formatter : IFormatter
    {
        public Formatter(
            [NotNull] long phoneNumber,
            [NotNull] int code,
            [NotNull] CountryPhoneCode countryCode)
        {
            throw new System.NotImplementedException();
        }

        public long PhoneNumber { get; private set; }

        public int Code { get; private set; }

        public CountryPhoneCode CountryPhoneCode { get; private set; }

        public FormattedPhoneNumber Format()
        {
            throw new System.NotImplementedException();
        }
    }
}
