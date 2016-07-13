namespace Cake.Genymotion
{
    public enum GenymotionReturnCode
    {
        NoError = 0,
        NoSuchAction = 1,
        BadParamValue = 2,
        CommandFailed = 3,
        VMEngineError = 4,
        DeviceNotFound = 5,
        CantLogin = 6,
        CantRegisterLicense = 7,
        CantActivateLicense = 8,
        NoActivatedLicense = 9,
        InvalidLicense = 10,
        MissingArguments = 11,
        VMNotStopped = 12,
        LicenseRequired = 13,
        CommandNotFoundUNIX = 127,
        SigTERM = 143
    }
}