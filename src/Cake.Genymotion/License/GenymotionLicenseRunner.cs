using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.License
{
    internal sealed class GenymotionLicenseRunner : GenymotionTool<GenymotionLicenseSettings>
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
            var arguments = CreateArgumentBuilder(Settings).Append("info");
            Run(Settings, arguments);
        }

        public void Register(string licenseKey)
        {
            if (string.IsNullOrWhiteSpace(licenseKey))
            {
                throw new ArgumentException(nameof(licenseKey));
            }

            var arguments = CreateArgumentBuilder(Settings).Append("register").AppendQuoted(licenseKey);
            Run(Settings, arguments);
        }

        public void Validity()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("validity");
            Run(Settings, arguments);
        }
    }
}