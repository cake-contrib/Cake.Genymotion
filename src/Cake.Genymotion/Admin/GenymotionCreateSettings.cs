using System.Collections.Generic;

namespace Cake.Genymotion
{
    public sealed class GenymotionCreateSettings : GenymotionSettings
    {
        public int AmountOfCPUs { get; set; }
        public int AmountOfRamInMb { get; set; }
        public string BridgedNetworkInterface { get; set; }
        public string Density { get; set; }
        public bool EnableNavbar { get; set; }
        public bool EnableVirtualKeyboard { get; set; }
        public int Height { get; set; }
        public GenymotionSimulatorNetworkMode SimulatorNetworkMode { get; set; }
        public Dictionary<string, string> SystemProperties { get; set; }
        public int Width { get; set; }
    }
}