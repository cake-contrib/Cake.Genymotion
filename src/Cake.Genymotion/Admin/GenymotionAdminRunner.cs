using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Sprache;
using System;
using System.Collections.Generic;

namespace Cake.Genymotion.Admin
{
    public sealed class GenymotionAdminRunner : GenymotionTool<GenymotionAdminSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionAdminRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner,
            IToolLocator tools, GenymotionAdminSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        public GenymotionReturnCode Clone(string deviceName, string newDeviceName)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Delete(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin delete").AppendQuoted(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public GenymotionDetailsResult Details(string deviceIdentifier)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenymotionDetailsResult> Details(IEnumerable<string> deviceIdentifier)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode FactoryReset(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin factoryreset").AppendQuoted(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public IEnumerable<GenymotionAdminListResult> List()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin list");

            var stdOutput = RunAndRedirectStandardOutput(Settings, arguments);

            return GenymotionAdminListGrammar.Simulators.Parse(stdOutput);
        }

        public GenymotionReturnCode LogZip(string deviceIdentifier, string logArchivePath)
        {
            throw new NotImplementedException();
        }

        public GenymotionReturnCode Reset(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin reset").AppendQuoted(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public GenymotionReturnCode Start(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin start").AppendQuoted(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public GenymotionReturnCode Stop(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin stop").AppendQuoted(deviceIdentifier);
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public GenymotionReturnCode StopAll()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin stopall");
            return (GenymotionReturnCode)RunProcess(Settings, arguments).GetExitCode();
        }

        public IEnumerable<GenymotionTemplateResult> Templates(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }
    }
}