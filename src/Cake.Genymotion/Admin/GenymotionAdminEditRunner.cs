using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Admin
{
    internal sealed class GenymotionAdminEditRunner : GenymotionTool<GenymotionEditSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionAdminEditRunner(IFileSystem fileSystem, ICakeEnvironment environment,
            IProcessRunner processRunner, IToolLocator tools, GenymotionEditSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        public GenymotionReturnCode Edit(string deviceName)
        {
            throw new NotImplementedException();
        }
    }
}