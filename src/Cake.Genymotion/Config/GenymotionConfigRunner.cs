using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.Genymotion.Config
{
    public sealed class GenymotionConfigRunner : GenymotionTool<GenymotionConfigSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionConfigRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools, GenymotionConfigSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        public void ClearCache()
        {
            throw new NotImplementedException();
        }

        public void Config()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }
    }
}