using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Genymotion.License;

namespace Cake.Genymotion.Tests.Fixtures.License
{
    internal sealed class GenymotionLicenseFixture : GenymotionFixture<GenymotionLicenseSettings>
    {
        protected override void RunTool()
        {
            //var tool = new DotNetCorePublisher(FileSystem, Environment, ProcessRunner, Tools);
            //tool.Publish(Project, Settings);
        }
    }
}
