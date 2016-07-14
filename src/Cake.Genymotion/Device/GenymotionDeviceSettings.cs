namespace Cake.Genymotion.Device
{
    public sealed class GenymotionDeviceSettings : GenymotionSettings
    {
        public string VirtualDeviceName { get; set; }

        // internal until named properly
        internal bool All { get; set; }

        // internal until named properly
        internal bool Start { get; set; }
    }
}