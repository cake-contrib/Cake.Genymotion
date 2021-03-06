﻿using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion.Version
{
    internal sealed class GenymotionVersionRunner : GenymotionTool<GenymotionVersionSettings>
    {
        private readonly ICakeEnvironment _environment;

        public GenymotionVersionRunner(IFileSystem fileSystem, ICakeEnvironment environment,
            IProcessRunner processRunner, IToolLocator tools, GenymotionVersionSettings settings) : base(fileSystem, environment, processRunner, tools, settings)
        {
            _environment = environment;
        }

        public void Version()
        {
            var arguments = CreateArgumentBuilder(Settings).Append("version");
            Run(Settings, arguments);
        }
    }
}