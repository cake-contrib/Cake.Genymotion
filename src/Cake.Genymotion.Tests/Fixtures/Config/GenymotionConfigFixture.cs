using System.Collections.Generic;
using System.IO;
using Cake.Genymotion;

namespace Cake.Genymotion.Tests.Fixtures.Config
{
    internal sealed class GenymotionConfigFixture : GenymotionFixture<GenymotionConfigSettings>
    {
        public GenymotionConfigFixture()
        {
            ProcessRunner.Process.SetStandardOutput(new[] {string.Empty});
        }

        protected override void RunTool()
        {
            var configRunner = new GenymotionConfigRunner(FileSystem, Environment, ProcessRunner, Tools, Settings);
            configRunner.Config();
        }
    }
}