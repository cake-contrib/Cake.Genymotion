using Cake.Genymotion.Admin;
using System.IO;

namespace Cake.Genymotion.Tests.Fixtures.Admin
{
    internal sealed class GenymotionAdminListFixture : GenymotionFixture<GenymotionAdminSettings>
    {
        public GenymotionAdminListFixture()
        {
            var standardOutput = File.ReadAllLines(@"Fixtures\Admin\AdminList.txt");
            ProcessRunner.Process.SetStandardOutput(standardOutput);
        }

        protected override void RunTool()
        {
            var adminRunner = new GenymotionAdminRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            adminRunner.List();
        }
    }
}