using Cake.Genymotion;
using Cake.Genymotion.License;

namespace Cake.Genymotion.Tests.Fixtures.License
{
    internal sealed class GenymotionLicenseRegisterFixture : GenymotionFixture<GenymotionLicenseSettings>
    {
        public string LicenseKey { get; set; }

        protected override void RunTool()
        {
            var licenseRunner = new GenymotionLicenseRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            licenseRunner.Register(LicenseKey);
        }
    }
}