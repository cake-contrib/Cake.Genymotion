using System.Collections;
using System.Collections.Generic;
using Cake.Genymotion.Admin;
using System.IO;
using Cake.Testing.Fixtures;

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