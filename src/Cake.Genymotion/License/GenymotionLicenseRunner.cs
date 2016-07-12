using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.License
{
    public sealed class GenymotionLicenseRunner : GenymotionTool<GenymotionLicenseSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionLicenseRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        public GenymotionReturnCode Count()
        {
            throw new NotImplementedException();

        }

        public GenymotionReturnCode Info()
        {
            throw new NotImplementedException();

        }

        public GenymotionReturnCode Register(string licenseKey)
        {
            throw new NotImplementedException();

        }

        public GenymotionReturnCode Validity()
        {
            throw new NotImplementedException();
        }
    }
}

