using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.Genymotion.Version
{
    public sealed class GenymotionVersionRunner : GenymotionTool<GenymotionVersionSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionVersionRunner(IFileSystem fileSystem, ICakeEnvironment environment,
            IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionVersion Version()
        {
            throw new NotImplementedException();
        }
    }
}