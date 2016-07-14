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

        public GenymotionReturnCode ClearCache()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Config()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Print()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Reset()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode SignOut()
        {
            throw new NotImplementedException();
        }
    }
}