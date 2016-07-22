using System.Collections.Generic;

namespace Cake.Genymotion.Admin
{
    public sealed class GenymotionSimulatorDetails
    {
        public string AndroidVersion { get; set; }
        public string APILevel { get; set; }
        public string GenymotionVersion { get; set; }
        public string IP { get; set; }
        public string Name { get; set; }
        public string NavBarVisible { get; set; }
        public string NbCPU { get; set; }
        public string NetworkMode { get; set; }
        public string Path { get; set; }
        public string RAM { get; set; }
        public string ScreenDensity { get; set; }
        public string ScreenDPI { get; set; }
        public string ScreenHeight { get; set; }
        public string ScreenWidth { get; set; }
        public string State { get; set; }
        public Dictionary<string, string> SystemProperties { get; set; }
        public bool Telephony { get; set; }
        public string UUID { get; set; }
    }
}