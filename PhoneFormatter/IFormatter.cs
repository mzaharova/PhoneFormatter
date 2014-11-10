namespace Bru.PhoneFormatter
{
    // TODO: Fill xml documentation.
    /// <summary>
    /// 
    /// </summary>
    public interface IFormatter
    {
        // TODO: Fill xml documentation.
        /// <summary>
        /// 
        /// </summary>
        long PhoneNumber { get; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// 
        /// </summary>
        int Code { get; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// 
        /// </summary>
        CountryPhoneCode CountryPhoneCode { get; }

        // TODO: Fill xml documentation.
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        FormattedPhoneNumber Format();
    }
}
