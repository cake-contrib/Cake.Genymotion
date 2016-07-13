namespace Cake.Genymotion.Config
{
    public sealed class GenymotionConfigSettings : GenymotionSettings
    {
        /// <summary>
        ///     Genymotion.com username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     Genymotion.com password
        /// </summary>
        public string Password { get; set; }

        public bool LicenseServer { get; set; }
        public string LicenseServerAddress { get; set; }
        public bool EnableStatistics { get; set; }
        public string VirtualDevicePath { get; set; }
        public string SdkPath { get; set; }
        public bool UseCustomSdk { get; set; }
        public string ScreenCapturePath { get; set; }
        public bool EnableProxy { get; set; }
        public string ProxyAddress { get; set; }
        public string ProxyPort { get; set; }
        public bool EnableProxyAuth { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
    }
}