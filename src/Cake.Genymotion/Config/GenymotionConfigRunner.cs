using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Config
{
    public sealed class GenymotionConfigRunner : GenymotionTool<GenymotionConfigSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionConfigRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionReturnCode Config()
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode ClearCache()
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