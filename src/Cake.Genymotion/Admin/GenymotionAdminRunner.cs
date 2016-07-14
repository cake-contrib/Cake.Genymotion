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

        public void Delete(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin delete").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public GenymotionDetailsResult Details(string deviceIdentifier)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenymotionDetailsResult> Details(IEnumerable<string> deviceIdentifier)
        {
            throw new NotImplementedException();
        }

        public void FactoryReset(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin factoryreset").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public IEnumerable<GenymotionAdminListResult> List()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin list");

            var stdOutput = RunAndRedirectStandardOutput(Settings, arguments);

            return GenymotionAdminListGrammar.Simulators.Parse(stdOutput);
        }

        public void LogZip(string deviceIdentifier, string logArchivePath)
        {
            throw new NotImplementedException();
        }

        public void Reset(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin reset").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void Start(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin start").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void Stop(string deviceIdentifier)
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin stop").AppendQuotedUnlessNullWhitespaceOrEmpty(deviceIdentifier);
            Run(Settings, arguments);
        }

        public void StopAll()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("admin stopall");
            Run(Settings, arguments);
        }

        public IEnumerable<GenymotionTemplateResult> Templates(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }
    }
}