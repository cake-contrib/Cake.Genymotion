using Cake.Genymotion;
using Cake.Testing.Fixtures;
using System.Collections;
using System.Collections.Generic;
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

        public IEnumerable<GenymotionAdminListResult> ToolResult { get; set; }

        protected override void RunTool()
        {
            var adminRunner = new GenymotionAdminRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            ToolResult = adminRunner.List();
        }
    }
}