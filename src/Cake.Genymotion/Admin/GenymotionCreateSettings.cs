using System.Collections.Generic;

namespace Cake.Genymotion.Admin
{
    public sealed class GenymotionCreateSettings : GenymotionSettings
    {
        public string Density { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int AmountOfCPUs { get; set; }
        public int AmountOfRamInMb { get; set; }
        public bool EnableNavbar { get; set; }
        public bool EnableVirtualKeyboard { get; set; }
        public GenymotionSimulatorNetworkMode SimulatorNetworkMode { get; set; }
        public string BridgedNetworkInterface { get; set; }
        public Dictionary<string, string> SystemProperties { get; set; }
    }
}