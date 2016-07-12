using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Genymotion.Admin
{
    public sealed class GenymotionEditSettings : GenymotionSettings
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
