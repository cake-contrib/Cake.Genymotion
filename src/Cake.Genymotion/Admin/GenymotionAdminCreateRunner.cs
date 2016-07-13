using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Admin
{
    public sealed class GenymotionAdminCreateRunner : GenymotionTool<GenymotionCreateSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionAdminCreateRunner(IFileSystem fileSystem, ICakeEnvironment environment,
            IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionReturnCode Create(string deviceName, string newDeviceName)
        {
            throw new NotImplementedException();
        }
    }
}