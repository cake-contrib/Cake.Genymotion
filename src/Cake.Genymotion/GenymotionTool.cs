using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Genymotion
{
    /// <summary>
    ///     Base class for all Genymotion related tools.
    /// </summary>
    /// <typeparam name="TSettings">The settings type.</typeparam>
    public abstract class GenymotionTool<TSettings> : Tool<TSettings>
        where TSettings : GenymotionSettings
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GenymotionTool{TSettings}" /> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        protected GenymotionTool(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
        }

        /// <summary>
        ///     Gets the name of the tool.
        /// </summary>
        /// <returns>The name of the tool.</returns>
        protected override string GetToolName()
        {
            return "Command line utility (gmtool/gmtool.exe) to control the Genymotion Simulator";
        }

        /// <summary>
        ///     Gets the possible names of the tool executable.
        /// </summary>
        /// <returns>The tool executable name.</returns>
        protected override IEnumerable<string> GetToolExecutableNames()
        {
            return new[]
            {
                "gmtool",
                "gmtool.exe"
            };
        }

        /// <summary>
        ///     Creates a <see cref="ProcessArgumentBuilder" /> and adds common commandline arguments.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Instance of <see cref="ProcessArgumentBuilder" />.</returns>
        protected ProcessArgumentBuilder CreateArgumentBuilder(TSettings settings)
        {
            var builder = new ProcessArgumentBuilder();

            if (settings.Verbose)
            {
                builder.Append("--verbose");
            }

            if (settings.Timeout != 0)
            {
                builder.Append($"--timeout {settings.Timeout}");
            }

            return builder;
        }


        /// <summary>
        ///     Runs the specified process, using the specified settings/arguments and returns the process StandardOutput.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="arguments">The arguments.</param>
        protected string RunAndRedirectStandardOutput(TSettings settings, ProcessArgumentBuilder arguments)
        {
            var stdOutput = string.Empty;

            Run(settings, arguments,
                new ProcessSettings
                {
                    RedirectStandardOutput = true,
                    Timeout = TimeSpan.FromSeconds(settings.Timeout).Milliseconds
                },
                process => stdOutput = string.Join(Environment.NewLine, process.GetStandardOutput()));

            return stdOutput;
        }
    }
}