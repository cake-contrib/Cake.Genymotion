using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Genymotion.License;

namespace Cake.Genymotion.Tests.Fixtures.License
{
    internal sealed class GenymotionLicenseInfoFixture : GenymotionFixture<GenymotionLicenseSettings>
    {
        protected override void RunTool()
        {
            var tool = new GenymotionLicenseRunner(FileSystem, Environment, ProcessRunner, Tools);
            tool.Info();
        }
    }
}
