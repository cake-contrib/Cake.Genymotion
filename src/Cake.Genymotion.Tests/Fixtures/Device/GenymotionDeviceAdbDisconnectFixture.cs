using Cake.Genymotion.Device;

namespace Cake.Genymotion.Tests.Fixtures.Device
{
    internal sealed class GenymotionDeviceAdbDisconnectFixture : GenymotionFixture<GenymotionDeviceSettings>
    {
        public string DeviceIdentifier { get; set; }

        protected override void RunTool()
        {
            var adminRunner = new GenymotionDeviceRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            adminRunner.AdbDisconnect(DeviceIdentifier);
        }
    }
}