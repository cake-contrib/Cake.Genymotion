using Cake.Genymotion.Device;

namespace Cake.Genymotion.Tests.Fixtures.Device
{
    internal sealed class GenymotionDeviceAdbDisconnectFixture : GenymotionFixture<GenymotionDeviceSettings>
    {
        protected override void RunTool()
        {
            var adminRunner = new GenymotionDeviceRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            adminRunner.AdbDisconnect(string.Empty);
        }
    }
}