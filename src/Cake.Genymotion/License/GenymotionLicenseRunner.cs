using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Genymotion.Admin;
using System;

namespace Cake.Genymotion.License
{
    public sealed class GenymotionLicenseRunner : GenymotionTool<GenymotionLicenseSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionLicenseRunner(IFileSystem fileSystem, ICakeEnvironment environment,
            IProcessRunner processRunner, IToolLocator tools, GenymotionLicenseSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        /// <summary>
        ///     retrieves amount of workstations the installed license is activated on from the Genymotion API.
        /// </summary>
        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public void Register(string licenseKey)
        {
            throw new NotImplementedException();
        }

        public void Validity()
        {
            throw new NotImplementedException();
        }
    }
}