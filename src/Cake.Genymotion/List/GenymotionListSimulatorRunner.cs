using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.List
{

    public sealed class GenymotionListSimulatorRunner : GenymotionTool<GenymotionListSimulatorSettings>
	{
        private readonly ICakeEnvironment _environment;

        public GenymotionListSimulatorRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
	    {
            _environment = environment;
        }
	}
}

