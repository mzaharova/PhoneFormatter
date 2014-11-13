namespace Bru.PhoneFormatter
{
    // TODO: Fill xml documentation.
    /// <summary>
    /// Returns the telephone number in the formatted form
    /// </summary>
    public interface IFormatter
    {
        // TODO: Fill xml documentation.
        /// <summary>
        /// Phone number of 6 figures
        /// </summary>
        long PhoneNumber { get; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// Phone code of the city of 3 figures
        /// </summary>
        int Code { get; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// Country Codes
        /// </summary>
        CountryPhoneCode CountryPhoneCode { get; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// Formation of number according to the set type is carried out
        /// </summary>
        /// <param name="fullInternalNumber">Determines in what form will the phone number</param>
        /// <returns>The telephone number in the formatted form</returns>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException"></exception>
        FormattedPhoneNumber Format(PhoneFormat fullInternalNumber);
    }
}
