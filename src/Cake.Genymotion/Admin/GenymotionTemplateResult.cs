namespace Cake.Genymotion.Admin
{
    /// <code>
    /// Name                  : Sony Xperia Z - 4.3 - API 18 - 1080x1920
    /// UUID                  : 8a807602-5d00-407d-b7d8-87e1726aca8f
    /// Description           : Sony Xperia Z(5", 1080x1920, XXHDPI) AOSP4.3 API 18
    /// Android Version       : 4.3
    /// API Level             : 18
    /// Genymotion Version    : 2.7.2
    /// Screen Width          : 1080
    /// Screen Height         : 1920
    /// Screen Density        : xxhdpi
    /// Screen DPI            : 480
    /// Nb CPU                : 1
    /// RAM                   : 2048
    /// Internal Storage      : 16384
    /// Telephony             : true
    /// Nav Bar Visible       : true
    /// Virtual Keyboard      : true
    /// Source                : genymotion
    /// Shared by             :
    /// </code>
    /// >
    public sealed class GenymotionTemplateResult
    {
        public string Name { get; set; }
        public string UUID { get; set; }
        public string Description { get; set; }
        public string AndroidVersion { get; set; }
        public int APILevel { get; set; }
        public string GenymotionVersion { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public AndroidScreenDensity ScreenDensity { get; set; }
        public int ScreenDPI { get; set; }
        public int NbCPU { get; set; }
        public int RAM { get; set; }
        public int InternalStorage { get; set; }
        public bool Telephony { get; set; }
        public bool NavBarVisible { get; set; }
        public bool VirtualKeyboard { get; set; }
        public string Source { get; set; }
        public string SharedBy { get; set; }
    }
}