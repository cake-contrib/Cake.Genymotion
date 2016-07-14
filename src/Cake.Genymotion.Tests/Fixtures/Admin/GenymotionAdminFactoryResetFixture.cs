using Cake.Genymotion.Admin;

namespace Cake.Genymotion.Tests.Fixtures.Admin
{
    internal sealed class GenymotionAdminFactoryResetFixture : GenymotionFixture<GenymotionAdminSettings>
    {
        public string DeviceIdentifier { get; set; }

        protected override void RunTool()
        {
            var adminRunner = new GenymotionAdminRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            adminRunner.FactoryReset(DeviceIdentifier);
        }
    }
}