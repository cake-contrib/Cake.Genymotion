using Cake.Core.IO;
using Cake.Testing.Fixtures;

namespace Cake.Genymotion.Tests.Fixtures
{
    internal abstract class GenymotionFixture<TSettings> : ToolFixture<TSettings, ToolFixtureResult>
        where TSettings : GenymotionSettings, new()
    {
        protected GenymotionFixture()
            : base("gmtool.exe")
        {
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }

        protected override ToolFixtureResult CreateResult(FilePath path, ProcessSettings process)
        {
            return new ToolFixtureResult(path, process);
        }
    }
}