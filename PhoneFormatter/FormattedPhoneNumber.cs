using JetBrains.Annotations;

namespace Bru.PhoneFormatter
{
    public class FormattedPhoneNumber
    {
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
        public string GetNationalFormattedPhone()
        {
            throw new System.NotImplementedException();
        }
    }
}
