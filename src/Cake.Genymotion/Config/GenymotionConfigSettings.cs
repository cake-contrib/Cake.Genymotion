namespace Cake.Genymotion
{
    public sealed class GenymotionConfigSettings : GenymotionSettings
    {
        public bool? EnableProxy { get; set; }

        public bool? EnableProxyAuth { get; set; }

        public bool? EnableStatistics { get; set; }

        public string LogArchivePath { get; set; }

        public bool? EnableLicenseServer { get; set; }

        public string LicenseServerAddress { get; set; }

        /// <summary>
        ///     Genymotion.com password
        /// </summary>
        public string Password { get; set; }

        public string ProxyAddress { get; set; }

        public string ProxyPassword { get; set; }

        public string ProxyPort { get; set; }

        public string ProxyUsername { get; set; }

        public string ScreenCapturePath { get; set; }

        public string SdkPath { get; set; }

        public bool? UseCustomSdk { get; set; }

        /// <summary>
        ///     Genymotion.com username
        /// </summary>
        public string Username { get; set; }

        public string VirtualDevicePath { get; set; }
    }
}