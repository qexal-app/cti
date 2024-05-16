namespace Qexal.CTI;

public static class Constants
{
    public const string UpdateUrl = "https://raw.githubusercontent.com/qexal-app/cti/main/version.xml";
    public const string Authority = "https://accounts.qexal.app";

#if DEBUG
    public const string ApiUrl = "https://localhost:7232/";
#else
        public const string ApiUrl = "https://cti.qexal.dev/";
#endif
    public const string ClientId = "microsip";
    public const string Scope = "openid offline_access";

    public const string AutoProvisioningUrl = ApiUrl + "configuration";
}
