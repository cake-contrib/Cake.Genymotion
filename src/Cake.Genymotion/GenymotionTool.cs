using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;
using System.Collections.Generic;

namespace Cake.Genymotion
{
    /// <summary>
    ///     Base class for all Genymotion related tools.
    /// </summary>
    /// <typeparam name="TSettings">The settings type.</typeparam>
    internal abstract class GenymotionTool<TSettings> : Tool<TSettings>
        where TSettings : GenymotionSettings
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GenymotionTool{TSettings}" /> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        /// <param name="settings">The settings.</param>
        protected GenymotionTool(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools, TSettings settings)
            : base(fileSystem, environment, processRunner, tools)
        {
            Settings = settings;
        }

        protected TSettings Settings { get; set; }

        /// <summary>
        ///     Creates a <see cref="ProcessArgumentBuilder" /> and adds common commandline arguments.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Instance of <see cref="ProcessArgumentBuilder" />.</returns>
        protected ProcessArgumentBuilder CreateArgumentBuilder(TSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var builder = new ProcessArgumentBuilder();

            if (settings.Verbose)
            {
                builder.Append("--verbose");
            }

            if (settings.Timeout.HasValue)
            {
                builder.Append($"--timeout {settings.Timeout}");
            }

            return builder;
        }

        /// <summary>
        ///     Gets alternative file paths which the tool may exist in
        /// </summary>
        /// <returns>The alternative locations for the tool.</returns>
        protected override IEnumerable<FilePath> GetAlternativeToolPaths(TSettings settings)
        {
            return new FilePath[]
            {
                new FilePath(@"C:\Program Files\Genymobile\Genymotion\gmtool.exe"),
                new FilePath(@"/Applications/Genymotion.app/Contents/MacOS/gmtool")
            };
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
        ///     Gets the name of the tool.
        /// </summary>
        /// <returns>The name of the tool.</returns>
        protected override string GetToolName()
        {
            return "Genymotion";
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
                    RedirectStandardOutput = true
                },
                process => stdOutput = string.Join(Environment.NewLine, process.GetStandardOutput()));

            return stdOutput;
        }
    }
}
