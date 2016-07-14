using Cake.Genymotion.Device;

namespace Cake.Genymotion.Tests.Fixtures.Device
{
    internal sealed class GenymotionDeviceAdbConnectFixture : GenymotionFixture<GenymotionDeviceSettings>
    {
        protected override void RunTool()
        {
            var adminRunner = new GenymotionDeviceRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            adminRunner.AdbConnect(string.Empty);
        }
    }
}