using Cake.Genymotion.License;

namespace Cake.Genymotion.Tests.Fixtures.License
{
    internal sealed class GenymotionLicenseCountFixture : GenymotionFixture<GenymotionLicenseSettings>
    {
        protected override void RunTool()
        {
            var licenseRunner = new GenymotionLicenseRunner(FileSystem, Environment, ProcessRunner, Tools);
            licenseRunner.Count();
        }
    }
}