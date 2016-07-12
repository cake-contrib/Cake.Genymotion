using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Config
{
    public sealed class GenymotionConfigRunner : GenymotionTool<GenymotionConfigSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionConfigRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public void Config()
        {

        }

        public void ClearCache()
        {
            
        }

        public void Print()
        {
            
        }

        public void Reset()
        {
            
        }

        public void SignOut()
        {
            
        }
    }
}

