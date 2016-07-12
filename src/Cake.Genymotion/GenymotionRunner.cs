using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Newtonsoft.Json;

namespace Cake.Genymotion
{
    internal class GenymotionRunner : Tool<GenymotionSettings>
    {
        readonly ICakeEnvironment _cakeEnvironment;

        public GenymotionRunner(IFileSystem fileSystem, ICakeEnvironment cakeEnvironment, IProcessRunner processRunner, IGlobber globber) 
            : base (fileSystem, cakeEnvironment, processRunner, globber)
        {
            _cakeEnvironment = cakeEnvironment;
        }

        protected override IEnumerable<string> GetToolExecutableNames()
        {
            return new[] { 
				"gmtool",
				"gmtool.exe"
			};
        }

        protected override string GetToolName()
        {
            return "Command line utility (gmtool) to control the Genymotion Simulator";
        }

        protected override IEnumerable<FilePath> GetAlternativeToolPaths(GenymotionSettings settings)
        {
            return new [] { 
				new FilePath("/Applications/Genymotion.app/Contents/MacOS/"),
				new FilePath(@"C:\Progra~1\Genymobile\Genymotion")
			};
        }

//        public IDictionary<string, IEnumerable<Simulator>> ListDevices(GenymotionSettings settings)
//        {
//            var builder = new ProcessArgumentBuilder();

//            builder.Append("list devices");
//            builder.Append(" ");
//            builder.Append("--json");

//            var stdOutput = RunProcess(settings, builder).GetStandardOutput().ToString();

//            return JsonConvert.DeserializeObject<SimCtlListDevicesResponse>(stdOutput).Devices;
//        }

//        public void ShutdownSimulator(GenymotionSettings settings, string uuid)
//        {
//            Process.Start("killall 'iOS Simulator'").WaitForExit(TimeSpan.FromSeconds(10).Milliseconds);
//            Process.Start("killall xcode").WaitForExit(TimeSpan.FromSeconds(10).Milliseconds);
//            Process.Start("killall -9 com.apple.CoreSimulator.CoreSimulatorService").WaitForExit(TimeSpan.FromSeconds(10).Milliseconds);

//            var builder = new ProcessArgumentBuilder();

//            builder.Append("shutdown");
//            builder.Append(" ");
//;           builder.AppendQuoted(uuid);
//            builder.Append(" --json");


//            // potential return codes for failure/success as follows:

//            // > simctl shutdown '1631D127-F9FC-410E-9139-46783A5630B4'
//            // An error was encountered processing the command(domain = com.apple.CoreSimulator.SimError, code = 159):
//            // Unable to shutdown device in current state: Shutdown
//            //
//            // › echo $?
//            // 159

//            // › simctl list devices | grep Booted
//            //         iPhone 6s(3A4D1CAE - 43FB - 4403 - 91E0 - 16E32BB8812B)(Booted)

//            // › simctl shutdown '3A4D1CAE-43FB-4403-91E0-16E32BB8812B'
//            // › echo $?
//            // 0

//            Run(settings, builder);
//        }

//        public void ShutdownAllSimulators(GenymotionSettings settings)
//        {
//            var devices = this.ListDevices(settings);

//            foreach (var device in devices)
//            {
//                var runningSimulators = device.Value.Where(x => x.State == SimulatorState.Booted);
//                foreach (var simulator in runningSimulators)
//                {
//                    this.ShutdownSimulator(settings, simulator.UDID);
//                }
//            }
//        }

//        public void ResetAllSimulators(GenymotionSettings settings)
//        {
//            this.ShutdownAllSimulators(settings);

//            var devices = this.ListDevices(settings);

//            // 3. https://gist.github.com/cabeca/cbaacbeb6a1cc4683aa5
//            // 4. xcrun simctl erase $uuid

//        }
    }
}
